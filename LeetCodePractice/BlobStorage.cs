using Azure.Storage.Blobs;
using System;

namespace BlobStorageExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Your_Azure_Storage_Connection_String";
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            Console.WriteLine("Listing containers:");
            foreach (var container in blobServiceClient.GetBlobContainers())
            {
                Console.WriteLine(container.Name);
            }
        }
    }
}
