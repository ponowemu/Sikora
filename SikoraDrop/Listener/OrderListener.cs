using Microsoft.AspNet.WebHooks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SikoraDrop.Controllers.Api
{
    [ApiController, Route("api/webhook/order")]
    public class OrderListener : Controller
    {
        public OrderListener()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("created")]
        public string Created()
        {
            return "ss";
        }
    }
}
