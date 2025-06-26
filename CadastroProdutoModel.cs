using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appComercio
{
    public class CadastroProdutoModel
    {
        public int id { get; set; }
        public string Produto { get; set; }
        public string Fornecedor { get; set; }
        public string cnpj { get; set; }
    }
}
