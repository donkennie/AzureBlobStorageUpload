using Azure.Storage.Blobs;

Console.WriteLine("Starting...");

var blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=blobstoragetodo;AccountKey=Edn+R/jwmMkva527z7R5TyXdHbvdq8v3NkTwaqVQ6dW93Uoy3c84LVuT7DVLspK01YH8EK4fdTEc+ASt32oSQg==;EndpointSuffix=core.windows.net";
var blobStorageContainerName = "uploadfile";

var container = new BlobContainerClient(blobStorageConnectionString, blobStorageContainerName);
var blob = container.GetBlobClient("kennie.jpeg");

var stream = File.OpenRead("kennie.jpeg");
await blob.UploadAsync(stream); 


Console.WriteLine("Upload Completed!");
