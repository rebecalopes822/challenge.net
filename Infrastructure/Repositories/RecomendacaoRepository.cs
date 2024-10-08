using netchallenge.Application.Interfaces;
using netchallenge.Domain.Entities;
using netchallenge.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace netchallenge.Infrastructure.Repositories
{
    public class RecomendacaoRepository : IRecomendacaoRepository
    {
        private readonly ApplicationDbContext _context;

        public RecomendacaoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Recomendacao>> GetAllAsync()
        {
            return await _context.Recomendacoes
                .Include(r => r.Paciente)  
                .Include(r => r.Tratamento) 
                .ToListAsync();
        }
        
        public async Task<Recomendacao?> GetByIdAsync(long id)
        {
            return await _context.Recomendacoes
                .Include(r => r.Paciente)  
                .Include(r => r.Tratamento) 
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task AddAsync(Recomendacao recomendacao)
        {
            await _context.Recomendacoes.AddAsync(recomendacao);
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateAsync(Recomendacao recomendacao)
        {
            _context.Recomendacoes.Update(recomendacao);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var recomendacao = await _context.Recomendacoes.FindAsync(id);
            if (recomendacao != null)
            {
                _context.Recomendacoes.Remove(recomendacao);
                await _context.SaveChangesAsync();
            }
        }
    }
}