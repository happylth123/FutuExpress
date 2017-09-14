using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FutuExpress.WebAPI.Controllers
{
    public class UserController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public Guid Post([FromBody] test request)
        {
            var a = request.name;
            return Guid.NewGuid();
        }

        public class test
        {
            public string name { get; set; }
        }
    }
}
