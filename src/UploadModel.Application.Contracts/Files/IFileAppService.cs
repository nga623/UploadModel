using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace UploadModel.Files
{
    public interface IFileAppService : IApplicationService
    {
        //Task<FileDto> FindByBlobNameAsync(string blobName);

        void CreateAsync(string name,byte[] bytes);
    }
}
