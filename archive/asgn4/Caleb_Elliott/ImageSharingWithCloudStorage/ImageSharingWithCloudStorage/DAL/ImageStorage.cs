using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace ImageSharingWithCloudStorage.DAL
{
    public class ImageStorage : IImageStorage
    {

        public const string ACCOUNT = "imagesharing";
        public const string CONTAINER = "images";

        protected readonly IWebHostEnvironment hostingEnvironment;

        protected ILogger<ImageStorage> logger;

        protected BlobServiceClient blobServiceClient;

        protected BlobContainerClient containerClient;

        protected bool UseBlobStorage { get; set; }

        public ImageStorage(IOptions<StorageOptions> storageOptions,
                            IWebHostEnvironment hostingEnvironment,
                            ILogger<ImageStorage> logger)
        {
            this.logger = logger;

            this.hostingEnvironment = hostingEnvironment;

            string connectionString = storageOptions.Value.ImageDb;

            UseBlobStorage = (connectionString != null && !("".Equals(connectionString)));

            if (UseBlobStorage)
            {
                logger.LogInformation("Using remote blob storage.");

                blobServiceClient = new BlobServiceClient(connectionString);

                containerClient = new BlobContainerClient(connectionString, CONTAINER);
            } 
            else
            {
                logger.LogInformation("Storing images on local file system.");
                mkDirectories();
            }
        }

        protected void mkDirectories()
        {
            var dataDir = Path.Combine(hostingEnvironment.WebRootPath,
               "data", "images");
            if (!Directory.Exists(dataDir))
            {
                Directory.CreateDirectory(dataDir);
            }
        }

        /**
         * The path on the local file system for a saved image.
         */
        protected string imageDataFile(int imageId)
        {
            return Path.Combine(
               hostingEnvironment.WebRootPath,
               "data", "images", "img-" + imageId + ".jpg");
        }

        /**
         * The context path on the local Web server for a saved image (must start with ~/).
         */
        protected static string imageContextPath(int imageId)
        {
            return "~/data/images/img-" + imageId + ".jpg";
        }

        /**
         * The name of a blob containing a saved image (id is key for metadata record).
         */
        protected static string BlobName (int imageId)
        {
            return "image-" + imageId + ".jpg";
        }

        protected string BlobUri (int imageId)
        {
            return containerClient.Uri + "/" + BlobName(imageId);
        }

        public async Task SaveFileAsync(IFormFile imageFile, int imageId)
        {
            if (UseBlobStorage) {

                logger.LogInformation("Saving image {0} to blob storage", imageId);

                BlobHttpHeaders headers = new BlobHttpHeaders();
                headers.ContentType = "image/jpeg";


                // upload data to blob storage
                string blobName = BlobName(imageId);
                BlobClient blobClient = containerClient.GetBlobClient(blobName);
                using (var fstream = imageFile.OpenReadStream())
                {
                    await blobClient.UploadAsync(fstream, headers);
                }
                

            } 
            else
            {
                logger.LogInformation("Saving image {0} to local storage", imageId);

                mkDirectories();
                // save image to local storage
                System.Drawing.Image img = System.Drawing.Image.FromStream(imageFile.OpenReadStream());
                if (img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Jpeg.Guid)
                {
                    string filepath = imageDataFile(imageId);
                    StreamWriter file = new StreamWriter(filepath);
                    await imageFile.CopyToAsync(file.BaseStream);
                }
                else
                {
                    logger.LogInformation("Incorrect image format for {0}, not saving to local storage", imageId);
                }

            }
        }

        public async Task RemoveFileAsync(int imageId)
        {
            string blobName = BlobName(imageId);
            await containerClient.DeleteBlobIfExistsAsync(blobName);
        }

        public string ImageUri(IUrlHelper urlHelper, int imageId)
        {
            if (UseBlobStorage)
            {
                return BlobUri(imageId);
            }
            else
            {
                return urlHelper.Content(imageContextPath(imageId));
            }
        }

    }
}