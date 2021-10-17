using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UploadModel.Files;
using Volo.Abp;
using Volo.Abp.BlobStoring;
using Volo.Abp.Http;

namespace UploadModel.File
{
    [RemoteService]
    [Route("api/file-management/files")]
    public class FileController : UploadModelController
    {


        protected IBlobContainer BlobContainer { get; }
        
        

        // protected IFileAppService FileAppService { get; }
        protected IFileAppService FileAppService { get; }
        //public FileController(IFileAppService fileAppService)
        //{
        //    // FileAppService = fileAppService;
        //}
        public FileController(IFileAppService fileAppService, IBlobContainer blobContainer)
        {
            FileAppService = fileAppService;

            BlobContainer = blobContainer;
        }
        [HttpPost]
        [Route("upload")]
        public virtual   void CreateAsync(IFormFile file)
        {
            BlobContainer.SaveAsync("123", file.GetAllBytes());
            // var   Bytes = System.IO.File.ReadAllBytes(@"D:\1.jpg");
            //  FileAppService.CreateAsync("123", Bytes);



            //   FileAppService.CreateAsync("123", file.GetAllBytes());
        }

    }
}
