using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Test_Asp_Core_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SqlController : ControllerBase
    {
        private UserRepository _repository;

        public SqlController(UserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult<string> Insert([FromBody]User user)
        {
            return HttpStatusCode.OK.ToString();

            //return _repository.InsertUser(user);
        }
    }
}
