using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.BlobStoring;

namespace UploadModel.Files
{
    public class FileAppService : UploadModelAppService, IFileAppService
    {
        protected IBlobContainer BlobContainer { get; }
        public void CreateAsync(string name, byte[] bytes)
        {
            BlobContainer.SaveAsync(name, bytes);
        }
        public FileAppService(  IBlobContainer blobContainer)
        {
            
            BlobContainer = blobContainer;
        }
    }
}
