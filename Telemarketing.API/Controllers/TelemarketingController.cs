using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Telemarketing.API.Models;
using Telemarketing.API.Service.Interface;

namespace Telemarketing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelemarketingController : ControllerBase
    {
        private readonly ITelemarketingService _telemarketingService;
        public TelemarketingController(ITelemarketingService telemarketingService) 
        {
            _telemarketingService = telemarketingService;
        }

        [HttpGet("BuscarPorIndicador")]
        public async Task<ActionResult> BuscarPorIndicador(int indicadorId)
        {
            var resultado = _telemarketingService.BuscarColetasPorIndicador(indicadorId);
            return null;
        }


        [HttpPost("/CriarIndicador")]
        public async Task<ActionResult> CriarIndicador(Indicador indicador)
        {
            await _telemarketingService.CriarIndicador(indicador);
            return null;
        }
    }
}
