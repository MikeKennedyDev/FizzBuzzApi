using FizzBuzzAPi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzAPi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        #region fields

        private readonly ILogger _logger;

        #endregion fields

        #region Controllers

        public FizzBuzzController(ILogger<FizzBuzzController> logger)
        {
            _logger = logger;
        }

        #endregion Controllers

        #region Methods

        // GET all action

        [HttpGet]
        public ActionResult<FizzBuzz> Get()
        {
            return new FizzBuzz();
        }

        [HttpGet("{fizz}/{buzz}")]
        public ActionResult<string[]> GetFizz(string fizz, string buzz)
        {
            return new FizzBuzz(fizz, buzz).FizzBuzzList;
        }

        // POST action

        // PUT action

        // DELETE action

        #endregion Methods
    }
}