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

        [HttpGet]
        public ActionResult<string[]> Get()
        {
            _logger.LogInformation("Standard Get with no parameters");
            return new FizzBuzz().FizzBuzzList;
        }

        [HttpGet("{fizz}/{buzz}")]
        public ActionResult<string[]> GetFizz(string fizz, string buzz)
        {
            _logger.LogInformation($"Get list with {fizz}, {buzz} as fizz, buzz");
            return new FizzBuzz(fizz, buzz).FizzBuzzList;
        }

        #endregion Methods
    }
}