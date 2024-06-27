using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.models
{
    public class Contrato
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public int ServicoId { get; set; }
    public decimal PrecoCobrado { get; set; }
    public DateTime DataContratacao { get; set; }
}
}