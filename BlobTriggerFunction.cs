using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionAppBlob
{
	public class BlobTriggerFunction
	{
		[FunctionName("BlobTriggerFunction")]
		public void Run([BlobTrigger("anchortransform/anchordata.json", Connection = "BlobStorageConnectionString")] Stream myBlob, string name, ILogger log)
		{
			log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
		}
	}
}
