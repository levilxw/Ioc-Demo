using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Services;
using Unity.AspNet.WebApi;

namespace AspWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ISend _send;

        public ValuesController(ISend send)
        {
            _send = send;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            var send = Request.GetDependencyScope().GetService(typeof(ISend)) as ISend;

            return new string[] { _send.GetGuid(), send?.GetGuid() };
        }
    }
}
