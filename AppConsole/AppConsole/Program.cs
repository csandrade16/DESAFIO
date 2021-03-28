using System;
using System.Globalization;
using System.Collections.Generic;

namespace AppConsole {
    class Program {
        static void Main(string[] args) {
            int opcao = 0; //Variável para escolha do menu
            while (opcao != 5) { //Fórmula quando o usuário digitar algo  errado


                Console.WriteLine("Bem - vindo(a) a sua Carteira de Investimentos!\n" +
                        "Aplicativo feito para você Investidor!\n" +
                        "Nesse APP voce pode ter uma visao global dos seus investimentos\n" +
                        "Utilize as nossas interações e acompanhe sua carteira:\n\n"); //Mensagem de inicialização

                Console.Write("Digite 1 - Para registrar a compra de um novo ativo na carteira\n" +
                    "Digite 2 - Para visualizar a lista de ativos investidos\n" +
                    "Digite 3 - Para informar a venda de seus ativos\n" +
                    "Digite 4 - Visualizar um resumo do valor total investido em todos os ativos\n" +
                    "Digite 5 - Para sair de sua Carteira de Investimentos\n"); //Descrição das operações a serem escolhidas pelo usuário

                Console.WriteLine(" ");
                opcao = int.Parse(Console.ReadLine()); //Fórmula para ler a opção do usuário

                Console.WriteLine("Você digitou a opção:" + opcao); //Confirmação da opção desejada
                Console.Clear();

                List<Investimento> list = new List<Investimento>(); //Criação da lista a ser adicionada.

                int s = 0;

                if (opcao == 1) 
                {
                    Investimento p = new Investimento();
                    Console.Clear();
                    Console.WriteLine("Você digitou a opção:" + opcao);
                    Console.WriteLine("Digite o nome do ativo");
                    p.Nome = Console.ReadLine();
                    Console.WriteLine("Quantos deseja comprar?");
                    p.Qte = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual valor unitário?");
                    p.VUnit = double.Parse(Console.ReadLine());
                    p.DtHr = Convert.ToString(DateTime.Now);

                    Console.WriteLine("Confirme as informações:");
                    Console.WriteLine("Nome:"
                                      + p.Nome
                                      + "Quantidade:"
                                      + p.Qte
                                      + "Valor Unitário:"
                                      + p.VUnit
                                      + "Valor Total ="
                                      + p.Qte * p.VUnit);
                }

                
                else if (opcao == 2) {
                    Console.WriteLine("Veja seu extrato a seguir:");

                    foreach (Investimento p in list ) {
                        Console.WriteLine("Nome:" + p.Nome + "; Quantidade:" + p.Qte + "; Valor Unitário: R$" + p.VUnit + ";Total: R$" + p.VTotal + "|" + p.DtHr);
                    }

                    Console.WriteLine("Para voltar ao menu anterior tecle Enter");
                    Console.ReadLine();
                }


            }

        }
    }
}
