using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadModel.Files;
using Xunit;

namespace UploadModel.File
{
    public class FileAppService_Tests : UploadModelApplicationTestBase
    {
        private readonly IFileAppService _fileAppService;

        public FileAppService_Tests()
        {
            _fileAppService = GetRequiredService<IFileAppService>();
        }


        [Fact]
        public void Create_FindByBlobName_Test()
        {
            var Bytes = System.IO.File.ReadAllBytes(@"D:\1.jpg");
            _fileAppService.CreateAsync("123.jpg", Bytes);
        }
    }
}
