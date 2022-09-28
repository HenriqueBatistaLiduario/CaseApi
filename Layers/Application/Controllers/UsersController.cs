using System;
using System.Net;
using System.Threading.Tasks;
using Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")] //http://localhost:5000/api/users
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _service { get; set; }
        public UsersController(IUserService service) //Injeção de dependência 
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
        [Route("{id}", Name = "GetWithId")] //Rota nomeada para o método Get por Id
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
    }
}
