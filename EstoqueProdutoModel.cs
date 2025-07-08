using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appComercio
{
    public class EstoqueProdutoModel
    {
        public int id { get; set; }
        public long CodBarraProduto { get; set; }
        public string FornecedorEst { get; set; }
        public long NumeroNota { get; set; }
        public string InformeProdutoEst { get; set; }
        public long Unidade { get; set; }
        public long EstMinimo { get; set; }
        public long EstMaximo { get; set; }
        public DateTime ValidadeEst { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public long QuantidadeEst { get; set; }
        public string Desativa { get;set;}
    }
}
