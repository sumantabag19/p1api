using EVA.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TestApplication.Contract.Business;
using TestApplication.Dto.Student;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("api/studentClass")]
    public class TestController : ControllerBase
    {
        private readonly IClassBusiness _ClassBusiness;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IHttpClientFactory _httpClientFactory;

        public TestController(IClassBusiness ClassBusiness, IUnitOfWork uow, IHttpContextAccessor httpContext, IHttpClientFactory httpClientFactory)
        {
            _ClassBusiness = ClassBusiness;
            _ClassBusiness.UnitOfWork = uow;
            _httpContext = httpContext;
            _httpClientFactory = httpClientFactory;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] ClassMasterAddDto classAdd)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join("",
                   ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                return BadRequest(message);
            }
            var result = await _ClassBusiness.Add(classAdd);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _ClassBusiness.GetAll();

            if (!response.Success) return StatusCode((int)HttpStatusCode.NotFound, new { StatusCode = (int)HttpStatusCode.NotFound, ErrorMessage = "Data not found" });

            return Ok(response);
        }
        [HttpGet("GetTagById")]
        public async Task<IActionResult> Get(long id)
        {
            var response = await _ClassBusiness.Get(id);
            if (!response.Success) return StatusCode((int)HttpStatusCode.NotFound, new { StatusCode = (int)HttpStatusCode.NotFound, ContactId = id, ErrorMessage = "Data not found" });
            return Ok(response);
        }
    }
}
