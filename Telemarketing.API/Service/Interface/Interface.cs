using Telemarketing.API.Models;

namespace Telemarketing.API.Service.Interface;

public interface ITelemarketingService
{
    Task<Indicador> CriarIndicador(Indicador indicador);
    Task<string> BuscarColetasPorIndicador(int indicadorId);
}
