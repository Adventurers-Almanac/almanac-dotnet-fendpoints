using AdventurersAlmanac.Domain.Contracts;
using AdventurersAlmanac.Domain.Entities;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

public class ProfileDataProvider : IProfileDataProvider
{

    // private readonly BlobServiceClient _blobServiceClient;
    // private readonly string _containerName;

    public ProfileDataProvider(IConfiguration configuration)
    {
        Colorful.Console.WriteLine("Creating ProfileDataProvider", Color.Coral);

        // string connectionString = configuration.GetConnectionString("BlobStorage");
        // _containerName = configuration.GetValue<string>("BlobContainerName");
        // _blobServiceClient = new BlobServiceClient(connectionString);
    }

    public async Task<string> SaveProfileAsync(Profile profile)
    {
        Colorful.Console.WriteLine("Calling ProfileDataProvider.SaveProfileAsync", Color.LightCoral);

        return await Task.FromResult(string.Empty);
    }


    public async Task<string> SaveProfilePictureAsync(byte[] profilePicture)
    {
        Colorful.Console.WriteLine("Calling ProfileDataProvider.SaveProfilePicture", Color.LightCoral);

        // string fileName = Guid.NewGuid().ToString();

        // BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
        // BlobClient blobClient = containerClient.GetBlobClient(fileName);

        // using (var stream = new MemoryStream(profilePicture))
        // {
        //     await blobClient.UploadAsync(stream, true);
        // }

        // return blobClient.Uri.ToString();

        return await Task.FromResult(string.Empty);
    }



}