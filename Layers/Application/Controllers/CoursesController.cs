using System;
using System.Net;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces.Services.Course;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")] //http://localhost:5000/api/courses
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private ICourseService _service { get; set; }
        public CoursesController(ICourseService service) //Injeção de dependência 
        {
            _service = service;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _service.GetAll()); //Consiste a Resposta de sucesso retornada pela requisição. (Se 200 OK)
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("{guid}", Name = "CoursesGetWithId")] //Rota nomeada para o método Get por Id
        public async Task<ActionResult> Get(Guid GUID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Get(GUID));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CourseEntity courses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Post(courses);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("CoursesGetWithId", new { GUID = result.GUID })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CourseEntity courses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Put(courses);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpDelete("{guid}")]
        public async Task<ActionResult> Delete(Guid GUID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Delete(GUID));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
