using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkateShopAPI.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int CEP { get; set; }
        public string Complemento { get; set; }
    }
}
