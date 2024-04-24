using System;
using System.IO;
using System.Net.NetworkInformation;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage.Blob;


namespace AzureFunctionAppBlob
{
	public class BlobTriggerFunction
	{
		[FunctionName("BlobTriggerFunction")]
		public void Run([BlobTrigger("anchortransform/anchordata.json", Connection = "BlobStorageConnectionString")] Stream myBlob, string name, ILogger log)
		{
			log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
			log.LogWarning("You are ok!");
		}
	}
}
