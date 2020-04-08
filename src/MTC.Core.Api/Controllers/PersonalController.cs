using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MTC.Model.DTOs;
using MTC.Service;
using MTC.Service.Commons;

namespace MTC.Core.Api.Controllers
{
    [ApiController]
    [Route("Personal")]
    public class PersonalController : ControllerBase
    {
        private readonly IPersonalService _personalService;

        public PersonalController(IPersonalService personalService)
        {
            _personalService = personalService;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public async Task<ActionResult> Create(PersonalCreateDto model)
        {
            var result = await _personalService.Create(model);
           
            return CreatedAtAction(
                "GetById",
                new { id = result.PersonalId },
                result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalDto>> GetById(int id)
        {
            return await _personalService.GetById(id);
        }

        [HttpGet]
        public async Task<ActionResult<DataCollection<PersonalDto>>> GetAll(int page, int take)
        {
            return await _personalService.GetAll(page, take);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, PersonalUpdateDto model)
        {
            await _personalService.Update(id, model);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Remove(int id)
        {
            await _personalService.Remove(id);
            return NoContent();
        }
    }
}