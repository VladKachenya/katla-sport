using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using KatlaSport.WebApi.CustomFilters;
using Microsoft.Web.Http;
using Swashbuckle.Swagger.Annotations;

namespace KatlaSport.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/Custom")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [CustomExceptionFilter]
    [SwaggerResponseRemoveDefaults]
    public class CustomController : ApiController
    {
        [HttpGet]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.OK, Description = "Returns a test string.", Type = typeof(string))]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public IHttpActionResult GetCustoms()
        {
            return Ok("Hello world!");
        }
    }
}