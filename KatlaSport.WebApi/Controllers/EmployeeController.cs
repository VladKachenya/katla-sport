using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Web.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using KatlaSport.Services.EmployeeManagement;
using KatlaSport.WebApi.CustomFilters;
using Swashbuckle.Swagger.Annotations;

namespace KatlaSport.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/employees")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [CustomExceptionFilter]
    [SwaggerResponseRemoveDefaults]
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.OK, Description = "Returns a list of employees.", Type = typeof(EmployeeListItem[]))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public async Task<IHttpActionResult> GetProducts([FromUri] int start = 0, [FromUri] int amount = 100, [FromUri] int? bossId = null)
        {
            if (start < 0)
            {
                return BadRequest("start");
            }
            if (amount < 0)
            {
                return BadRequest("amount");
            }
            if (bossId.HasValue && bossId.Value < 0)
            {
                return BadRequest("bossId");
            }

            List<EmployeeListItem> employees;
            if (bossId.HasValue)
            {
                employees = await _employeeService.GetSubordinateEmployeesAsync(start, amount, bossId.Value);
            }
            else
            {
                employees = await _employeeService.GetEmployeesAsync(start, amount);
            }
            return Ok(employees);
        }
    }
}