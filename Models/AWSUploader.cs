using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Amazon.S3;
using Amazon;
using Amazon.S3.Transfer;
namespace GearsStore.Models
{
    public class AWSUploader
    {
          
  

            public bool sendMyFileToS3(FileStream localFilePath, string bucketName, string fileNameInS3)
            {
                IAmazonS3 client = new AmazonS3Client(ConfigurationManager.AppSettings["AWSAccessKey"], ConfigurationManager.AppSettings["AWSSecretKey"],RegionEndpoint.USEast1);
                TransferUtility utility = new TransferUtility(client); 
                TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();

                
                request.BucketName = bucketName;
                request.Key = fileNameInS3; //file name up in S3  
                request.InputStream = localFilePath;
                utility.Upload(request); //commensing the transfer  

                return true; //indicate that the file was sent  
            }
    }
    
}
