using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace appComercio
{
    public static class APIRotasController
    {
        private static readonly string conexao = "http://127.0.0.1:5000";

        public static string CadastroUsuario => $"{conexao}/CadastroUsuario";
        public static string EstoqueProduto => $"{conexao}/EstoqueProduto";
        public static string CadastroProdutoServico => $"{conexao}/CadastroProdutoServico";
        public static string FornecedorProduto => $"{conexao}/FornecedorProduto";


    }
}
