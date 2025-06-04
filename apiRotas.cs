using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appComercio
{
    public static class apiRotas
    {
        private static readonly string baseUrl = "http://127.0.0.1:5000";

        public static string CadastroUsuario => $"{baseUrl}/CadastroUsuario";
        // Adicione mais endpoints aqui, se quiser:
        // public static string Produtos => $"{baseUrl}/Produtos";
        // public static string Clientes => $"{baseUrl}/Clientes";
    }
}
