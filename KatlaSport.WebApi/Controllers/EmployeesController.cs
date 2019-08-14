﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
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
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.OK, Description = "Returns a list of employees.", Type = typeof(EmployeeListItem[]))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public async Task<IHttpActionResult> GetEmployees([FromUri] int start = 0, [FromUri] int amount = 100, [FromUri] int? bossId = null)
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

        [HttpGet]
        [Route("{id:int:min(1)}")]
        [SwaggerResponse(HttpStatusCode.OK, Description = "Returns an employee .", Type = typeof(Employee))]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public async Task<IHttpActionResult> GetEmployee([FromUri] int id)
        {
            var employee = await _employeeService.GetEmployeeAsync(id);
            return Ok(employee);
        }

        [HttpPost]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.Created, Description = "Creates a new employee.")]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.Conflict)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public async Task<IHttpActionResult> AddEmployee([FromBody] UpdateEmployeeRequest createRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var location = string.Format("/api/employees/{0}", 0);
            return Created(location, 0);
        }

        [HttpPut]
        [Route("{employeeId:int:min(1)}/status/{deletedStatus:bool}")]
        [SwaggerResponse(HttpStatusCode.NoContent, Description = "Sets deleted status for an existed employee.")]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public async Task<IHttpActionResult> SetStatus([FromUri] int employeeId, [FromUri] bool deletedStatus)
        {
            await _employeeService.SetStatusAsync(employeeId, deletedStatus);
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.NoContent));
        }
    }
}