using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ImageSharingWithCloudStorage.Models
{
    public class LogEntry : TableEntity
    {
        public LogEntry() { this.ListOfTimeIntervals = createDates(); }
        public LogEntry(int imageId) { CreateKeys(imageId);
            this.ListOfTimeIntervals = createDates();
        }

        public DateTime EntryDate { get; set; }

        public string Username { get; set; }

        public string Caption { get; set; }

        public string Uri { get; set; }

        public int ImageId { get; set; }

        public IEnumerable<LogEntry> entries { get; set; }

        public virtual int DateId { get; set; }
        public List<SelectListItem> ListOfTimeIntervals { get; set; }
  
        public void CreateKeys(int imageId)
        {
            EntryDate = DateTime.UtcNow;

            PartitionKey = EntryDate.ToString("MMddyyyy");

            this.ImageId = imageId;

            RowKey = string.Format("{0}-{1:10}_{2}",
                imageId,
                DateTime.MaxValue.Ticks - EntryDate.Ticks,
                Guid.NewGuid());
        }

        private List<SelectListItem> createDates()
        {
            List<SelectListItem> listOfDates = new List<SelectListItem>();

            for (DateTime date = DateTime.Now; date >= DateTime.Now.AddDays(-14); date = date.AddDays(-1))
            {
                listOfDates.Add(new SelectListItem { Value = date.ToString("MMddyyyy"), Text = date.ToString("M") });
            }

            return (listOfDates);
        }
    }
}