using FizzBuzzAPi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzAPi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        #region fields

        private readonly ILogger<FizzBuzzController> _logger;

        #endregion fields

        #region Controllers

        public FizzBuzzController(ILogger<FizzBuzzController> logger)
        {
            _logger = logger;
        }

        #endregion Controllers

        #region Methods

        // GET all action

        // GET by Id action
        [HttpGet]
        public ActionResult<FizzBuzz> Get()
        {
            return new FizzBuzz();
        }

        // POST action

        // PUT action

        // DELETE action

        #endregion Methods
    }
}