using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreService.WeiPinHui;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestCoreApi.Controllers
{
    /// <summary>
    /// 唯品会
    /// </summary>
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class WeiPinHuiController : ControllerBase
    {
        /// <summary>
        /// query接口
        /// 根据关键词查询商品列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> SearchGoodsList()
        {
            return new WPHVipService().SearchGoodsList();
        }
    }
}