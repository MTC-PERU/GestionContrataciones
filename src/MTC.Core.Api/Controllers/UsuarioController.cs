using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MTC.Model.DTOs;
using MTC.Service;
using MTC.Service.Commons;

namespace MTC.Core.Api.Controllers
{
    [ApiController]
    [Route("Usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<ActionResult> Create(UsuarioCreateDto model)
        {
            var result = await _usuarioService.Create(model);
            return CreatedAtAction(
                "GetById", 
                new {id = result.UsuarioId}, 
                result);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioDto>> GetById(int id)
        {
            return await _usuarioService.GetById(id);
        }

        [HttpGet]
        public async Task<ActionResult<DataCollection<UsuarioDto>>> GetById(int page, int take)
        {
            return await _usuarioService.GetAll(page, take);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UsuarioUpdateDto model)
        {
            await _usuarioService.Update(id, model);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Remove(int id)
        {
            await _usuarioService.Remove(id);
            return NoContent();
        }
    }
}
