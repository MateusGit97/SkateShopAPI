using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkateShopAPI.Models
{
    public class Cliente
    {
        public int CPF { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
    }
}
