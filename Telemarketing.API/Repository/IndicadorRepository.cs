using Microsoft.EntityFrameworkCore;
using Telemarketing.API.Data;
using Telemarketing.API.Models;
using Telemarketing.API.Repository.Interface;

namespace Telemarketing.API.Repository;

public class IndicadorRepository : IIndicadorRepository
{
    private readonly ApplicationDbContext _context;
    public IndicadorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Indicador?> BuscarIndicador(int indicadorId)
    {
        return await _context.Indicadores.FirstOrDefaultAsync(p => p.Id == indicadorId);
    }

    public async Task<Indicador> CriarIndicador(Indicador indicador)
    {
        _context.Indicadores.Add(indicador);
        await _context.SaveChangesAsync();
        return indicador;
    }
}
