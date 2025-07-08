using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appComercio
{
    public class CadastroProdutoServicoModel
    {
        public long Id { get; set; }
        public int CodBarra { get; set; }
        public string InformeProduto { get; set; }
        public string Fornecedor { get; set; }
        public string TipoFornecedor { get; set; }
        public int Quantidade { get; set; }
        
    }
}
