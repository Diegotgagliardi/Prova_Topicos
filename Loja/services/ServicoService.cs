using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loja.data;
using Loja.models;
using Microsoft.EntityFrameworkCore;

namespace Loja.services
{
    public class ServicoService
    {
        private readonly LojaDbContext _context;

        public ServicoService(LojaDbContext context)
        {
            _context = context;
        }

        public async Task<Servico> AddServicoAsync(Servico servico)
        {
            _context.Servicos.Add(servico);
            await _context.SaveChangesAsync();
            return servico;
        }
        public async Task UpdateServicoAsync(Servico servico)
        {
            _context.Servicos.Update(servico); // Marca o serviço como modificado
            await _context.SaveChangesAsync(); // Salva as alterações no banco de dados
        }

        internal Servico GetServicoById(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<Servico> GetServicoByIdAsync(int id)
    {
        return await _context.Servicos.FindAsync(id);
    }
    }
}