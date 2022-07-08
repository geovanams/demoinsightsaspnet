using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace DemoAspnetcore.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly string url = "https://aspnetfuncapp.azurewebsites.net/api/HttpAppFunc?code=u5NNRw2k7RJ9b3JkVAy6fin8OkzdXgzn6nZmw8u2ep-kAzFulbvNkA==";

        public DemoController()
        { }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var text = await response.Content.ReadAsStringAsync();

            return new OkObjectResult(text);
        }

    }
}
