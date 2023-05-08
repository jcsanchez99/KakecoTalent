using KakecoTalent.Application.UseCase.UseCases.Commands.CreateCommand.General.KakecoSoft;
using KakecoTalent.Application.UseCase.UseCases.Commands.DeleteCommand.General.KakecoSoft;
using KakecoTalent.Application.UseCase.UseCases.Commands.UpdateCommand.General.KakecoSoft;
using KakecoTalent.Application.UseCase.UseCases.Queries.GetAllQuery.General.KakecoSoft;
using KakecoTalent.Application.UseCase.UseCases.Queries.GetByIdQuery.General.KakecoSoft;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KakecoTalent.API.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class KakecoSoftController : ControllerBase
    {
        private readonly IMediator _meditor;
        public KakecoSoftController(IMediator meditor)
        {
            _meditor = meditor;
        }

        [HttpGet]
        public async Task<IActionResult> ListKakecoSoft()
        {
            var response = await _meditor.Send(new GetAllKakecoSoftQuery());
            return Ok(response);
        }

        [HttpGet("{kakecoSoftId:int}")]
        public async Task<IActionResult> KakecoSoftById(int kakecoSoftId)
        {
            var response = await _meditor.Send(new GetKakecoSoftByIdQuery() { KakecoSoftId = kakecoSoftId });
            return Ok(response);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterKakecoSoft([FromBody] CreateKakecoSoftCommand command)
        {
            var response = await _meditor.Send(command);
            return Ok(response);
        }


        [HttpPut("{Edit}")]
        public async Task<IActionResult> EditKakecoSoft([FromBody] UpdateKakecoSoftCommand command)
        {
            var response = await _meditor.Send(command);
            return Ok(response);
        }

        [HttpDelete("Delete/{Id:int}")]
        public async Task<IActionResult> DeleteKakecoSoft(int _Id)
        {
            var response = await _meditor.Send(new DeleteKakecoSoftCommand() { Id = _Id });
            return Ok(response);
        }
    }


}
