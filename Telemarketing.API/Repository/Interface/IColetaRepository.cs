using Telemarketing.API.Models;

namespace Telemarketing.API.Repository.Interface
{
    public interface IColetaRepository
    {
        Task<List<Coleta>> BuscarColetasPorIndicadorId(int indicadorId);
        Task<Coleta> CriarColeta(Coleta Coleta);
    }
}
