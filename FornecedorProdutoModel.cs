using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appComercio
{
    internal class FornecedorProdutoModel
    {
        public long Cnpj { get; set; }
        public long CodBarraFornecedor { get; set; }
        public string InformeProdutoForn { get; set; }
        public string NomeFornecedor { get; set; }
        public string EndFornecedor { get; set; }
    }
}
