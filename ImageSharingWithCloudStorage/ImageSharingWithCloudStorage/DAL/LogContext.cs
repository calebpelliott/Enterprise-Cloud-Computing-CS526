using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ImageSharingWithCloudStorage.Models;

using Microsoft.Azure.Cosmos.Table;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

namespace ImageSharingWithCloudStorage.DAL
{
    public class LogContext : ILogContext
    {
        public const string LOG_TABLE_NAME = "imageviews";

        protected CloudTable table;

        protected ILogger<LogContext> logger;

        protected bool useLogging;

        public LogContext(IOptions<StorageOptions> options, ILogger<LogContext> logger)
        {
            this.useLogging = !(options.Value.LogEntryDb == "YOUR CONNECTION STRING FOR TABLE"); 
            this.logger = logger;

            /*
             * Initialize the table.  The connection string is LogEntryDb in options.
             */           
            if (useLogging)
            {
                this.table = GetTable(options.Value.LogEntryDb);
            }

        }


        protected CloudStorageAccount CreateStorageAccountFromConnectionString(string storageConnectionString)
        {
            CloudStorageAccount storageAccount;
            try
            {
                storageAccount = CloudStorageAccount.Parse(storageConnectionString);
            }
            catch (FormatException)
            {
                logger.LogError("Invalid storage account information format: {0}", storageConnectionString);
                throw;
            }
            catch (ArgumentException)
            {
                logger.LogError("Invalid storage account information provided. Please confirm the AccountName and AccountKey are valid in the app.config file - then restart the sample.");
                throw;
            }

            return storageAccount;
        }

        protected CloudTable GetTable(string storageConnectionString)
        {
            // Retrieve storage account information from connection string.
            CloudStorageAccount storageAccount = CreateStorageAccountFromConnectionString(storageConnectionString);

            // Create a table client for interacting with the table service 
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient(new TableClientConfiguration());
            CloudTable table = tableClient.GetTableReference(LOG_TABLE_NAME);
            
            return table;
        }

        public async Task<CloudTable> CreateTableAsync()
        {
            if (!useLogging)
            {
                return null;
            }

            if (await table.CreateIfNotExistsAsync())
            {
                logger.LogInformation("Created Table named: {0}", LOG_TABLE_NAME);
            }
            else
            {
                logger.LogInformation("Table {0} already exists", LOG_TABLE_NAME);
            }

            return table;
        }

        public async Task AddLogEntryAsync(string user, ImageView image)
        {
            if (!useLogging)
            {
                return;
            }

            LogEntry entry = new LogEntry(image.Id);
            entry.Username = user;
            entry.Caption = image.Caption;
            entry.ImageId = image.Id;
            entry.Uri = image.Uri;

            logger.LogInformation("Adding log entry for image: {0}", image.Id);

            // add a log entry for this image view
            TableOperation insertOperation = TableOperation.Insert(entry);
            TableResult result = await this.table.ExecuteAsync(insertOperation);

            
            if (result != null && result.RequestCharge.HasValue)
            {
                logger.LogInformation("Added log entry with charge {0}", result.RequestCharge.Value);
            }
        }

        public IEnumerable<LogEntry> LogsToday()
        {
            TableQuery<LogEntry> query = new TableQuery<LogEntry>().Where(
                TableQuery.GenerateFilterCondition("PartitionKey", 
                                    QueryComparisons.Equal, 
                                    DateTime.UtcNow.ToString("MMddyyyy")));

            return table.ExecuteQuery(query);
        }

    }
}