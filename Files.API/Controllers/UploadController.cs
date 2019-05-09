using Basic.Lib;
using Files.IService;
using Files.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Files.API.Controllers
{
    /// <summary>
    /// 文件上传
    /// </summary>
    [Route("file/api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class UploadController : ControllerBase
    {
        private readonly IUploadService _uploadService;
        public UploadController(IUploadService uploadService)
        {
            _uploadService = uploadService;
        }

        /// <summary>
        /// 表单模式多文件上传
        /// </summary>
        /// <param name="appid">编号</param>
        /// <returns></returns>
        [HttpPost,Route("{appid}")]
        public async Task<ReturnResult<UploadReturnModel>> UploadSmallFilesByForm(string appid) {

            var files = Request.Form.Files;
            
            return await _uploadService.UploadSmallFile(appid, files);
        }

        /// <summary>
        /// 表单模式单文件上传
        /// </summary>
        /// <param name="formFile"></param>
        /// <param name="appid">编号</param>
        /// <returns></returns>
        [HttpPost]
        public ReturnResult UploadFile(IFormFile formFile, string appid)
        {
            FormFileCollection files = new FormFileCollection();
            files.Add(formFile);
            _uploadService.UploadSmallFile(appid, files);
            return new ReturnResult(null);
        }

    }
}