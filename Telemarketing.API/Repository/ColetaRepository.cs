using Microsoft.EntityFrameworkCore;
using Telemarketing.API.Data;
using Telemarketing.API.Models;
using Telemarketing.API.Repository.Interface;

namespace Telemarketing.API.Repository;

public class ColetaRepository : IColetaRepository
{
    private readonly ApplicationDbContext _context;
    public ColetaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Coleta>> BuscarColetasPorIndicadorId(int indicadorId)
    {
        return await _context.Coletas.Where(p => p.IndicadorId == indicadorId).ToListAsync();
    }

    public async Task<Coleta> CriarColeta(Coleta coleta)
    {
        _context.Coletas.Add(coleta);
        await _context.SaveChangesAsync();
        return coleta;
    }
}
