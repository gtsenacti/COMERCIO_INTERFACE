namespace appComercio
{
    public static class apiRotasController
    {
        private static readonly string baseUrl = "http://127.0.0.1:5000";

        public static string CadastroUsuario => $"{baseUrl}/CadastroUsuario";
        // Adicione mais endpoints aqui, se quiser:
        public static string CadastroProduto => $"{baseUrl}/CadastroProduto";
        // public static string Clientes => $"{baseUrl}/Clientes";
    }
}
