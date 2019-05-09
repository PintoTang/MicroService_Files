using Basic.Lib;
using Files.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Files.IService
{
    public interface IUploadService
    {
        Task<ReturnResult<UploadReturnModel>> UploadSmallFile(string appid, IFormFileCollection files);
    }
}
