using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loja.data;
using Loja.models;
using Microsoft.EntityFrameworkCore;

namespace Loja.services
{
    public class ContratoService
{
    private readonly LojaDbContext _context;

    public ContratoService(LojaDbContext context)
    {
        _context = context;
    }

    public async Task<Contrato> AddContratoAsync(Contrato contrato)
    {
        _context.Contratos.Add(contrato);
        await _context.SaveChangesAsync();
        return contrato;
    }

    public async Task<Cliente> GetClienteByIdAsync(int clienteId)
    {
        return await _context.Clientes.FindAsync(clienteId);
    }

    public async Task<Servico> GetServicoByIdAsync(int servicoId)
    {
        return await _context.Servicos.FindAsync(servicoId);
    }
    public async Task<List<Contrato>> GetContratosByClienteIdAsync(int clienteId)
    {
        return await _context.Contratos.Where(c => c.ClienteId == clienteId).ToListAsync();
    }
}
}