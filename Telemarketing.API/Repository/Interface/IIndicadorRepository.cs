using Telemarketing.API.Models;

namespace Telemarketing.API.Repository.Interface
{
    public interface IIndicadorRepository
    {
        Task<Indicador> CriarIndicador(Indicador indicador);
        Task<Indicador?> BuscarIndicador(int indicadorId);
    }
}
