
using Basic.Lib;
using Files.IService;
using Files.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Files.API.Controllers
{
    /// <summary>
    /// 归属方
    /// </summary>
    [Route("file/api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class DomainController : ControllerBase
    {
        private readonly IDomainService _domainService;
        public DomainController(IDomainService domainService) {
            _domainService = domainService;
        }

        /// <summary>
        /// 开通文件系统
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost,Route("open")]
        public ReturnResult<ReturnOpenModel> OpenDomain([FromBody]OpenModel model) {
            if (model == null)
                return new ReturnResult<ReturnOpenModel>((int)ErrorCodeEnum.Parameter_Missing, null, "参数异常!");
            return _domainService.OpenDomain(model);
        }


    }
}