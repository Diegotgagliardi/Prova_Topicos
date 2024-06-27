using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.models
{
    public class Servico
    {
        public int Id { get; set; }
        public String Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public bool Status { get; set; } 
    }
}