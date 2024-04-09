using Telemarketing.API.Models;
using Telemarketing.API.Repository.Interface;
using Telemarketing.API.Service.Interface;

namespace Telemarketing.API.Service
{
    public class TelemarketingService : ITelemarketingService
    {
        private readonly IIndicadorRepository _indicadorRepository;
        private readonly IColetaRepository _coletaRepository;
        public TelemarketingService(
            IIndicadorRepository indicadorRepository,
            IColetaRepository coletaRepository
            )
        {
            _indicadorRepository = indicadorRepository;
            _coletaRepository = coletaRepository;
        }

        public async Task<string> BuscarColetasPorIndicador(int indicadorId)
        {
            var indicador = await _indicadorRepository.BuscarIndicador(indicadorId);

            if (indicador == null)
                return $"Não foi encontrado nenhum indicador registrado com o id {indicadorId}.";

            var coletas = await _coletaRepository.BuscarColetasPorIndicadorId(indicadorId);

            if (coletas == null)
                return "Não foi encontrado nenhum dado registrado.";
                
            var ultimoDia = coletas.OrderByDescending(p => p.Data).First().Data; 
            if (indicador.TipoColeta == TipoColeta.Media)
            {
                var media = coletas.Average(p => p.ValorColetado);
                return $"Resultado até o dia {ultimoDia.AddDays(1).ToString("dd/MM/yyyy")}: {media.ToString("C2")}";
            }
            else if (indicador.TipoColeta == TipoColeta.Soma)
            {
                var soma = coletas.Sum(p => p.ValorColetado);
                return $"Resultado parcial até o dia {ultimoDia.AddDays(1).ToString("dd/MM/yyyy")}: R$ {soma.ToString("C2")}";
            }

            return "Não foi encontrado nenhum dado registrado.";
        }

        public async Task<Indicador> CriarIndicador(Indicador indicador)
        {
            return await _indicadorRepository.CriarIndicador(indicador);
        }
    }
}
