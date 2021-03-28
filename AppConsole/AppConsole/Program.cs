using System;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem - vindo(a) a sua Carteira de Investimentos!\n" +
                    "Aplicativo feito para você Investidor!\n" +
                    "Nesse APP voce pode ter uma visao global dos seus investimentos\n" +
                    "Utilize as nossas interações e acompanhe sua carteira:\n\n"); //Mensagem de inicialização

            Console.Write("Digite 1 - Para registrar a compra de um novo ativo na carteira\n" +
                "Digite 2 - Para visualizar a lista de ativos investidos\n" +
                "Digite 3 - Para informar a venda de seus ativos\n" +
                "Digite 4 - Visualizar um resumo do valor total investido em todos os ativos\n" +
                "Digite 5 - Para sair de sua Carteira de Investimentos\n"); //Descrição das operações a serem escolhidas pelo usuário
        }
    }
}
