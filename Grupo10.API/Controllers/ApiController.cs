using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Grupo10.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {

        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        #region HTTP

        [HttpGet(Name = "Get")]
        public IEnumerable<object> Get()
        { 
            try
            {
                _logger.LogInformation("==== Start Get method ====");


                //TODO: Llamada a interfaz de base de datos
                

                return null;
            }
            catch (Exception ex)
            { 
                _logger.LogError("==== Exception at Get. {0}", ex.InnerException);
                throw;
            }
        }

        #endregion
    }
}