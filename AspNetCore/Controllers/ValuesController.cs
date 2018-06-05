using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace AspNetCore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ISend _send;

        public ValuesController(ISend send)
        {
            _send = send;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var serviceProvider = Request.HttpContext.RequestServices;

            // 此处获取到的send与_send为同一个实例，表示在相同的scope;
            var send = serviceProvider.GetService(typeof(ISend)) as ISend;

            return new string[] { _send.GetGuid(), send?.GetGuid() };
        }
    }
}
