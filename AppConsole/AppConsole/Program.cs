using System;
using System.Globalization;
using System.Collections.Generic;


namespace AppConsole {
    class Program {
        static void Main(string[] args) {
            int opcao = 0; //Variável para escolha do menu

            List<Investimento> listaativo = new List<Investimento>(); //Criação da lista a ser adicionada.

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

                int s = 0;

                if (opcao == 1) {

                    Console.WriteLine("Você digitou a opção:" + opcao
                            + "\nSe deseja cancelar, aperte 9;" + //Opção de retornar ao menu
                            "\nPara prosseguir aperte 1 novamente");
                    s = int.Parse(Console.ReadLine());

                    Investimento ativo = new Investimento();

                    if (s == 1) {

                        Console.Clear();
                        Console.WriteLine("Digite o nome do ativo");
                        ativo.Nome = Console.ReadLine();
                        Console.WriteLine("Quantos deseja comprar?");
                        ativo.Qte = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual valor unitário? $");
                        ativo.VUnit = double.Parse(Console.ReadLine());
                        ativo.DtHr = Convert.ToString(DateTime.Now);



                        Console.WriteLine("Confirme as informações:");

                        ativo.ConfAdicionar();
                        listaativo.Add(ativo);
                    }
                    else if (s != 9)
                        Console.WriteLine("Opção inválida");
                }


                else if (opcao == 2) {
                    Console.WriteLine("Você digitou a opção:" + opcao
                            + "\nSe deseja cancelar, aperte 9;" + //Opção de retornar ao menu
                            "\nPara prosseguir aperte 2 novamente");
                    s = int.Parse(Console.ReadLine());

                    if (s == 2) {
                        Console.WriteLine("Veja seu extrato a seguir:");

                        foreach (Investimento ativo in listaativo) {

                            ativo.ExtratonoConsole();
                        }
                        Console.ReadLine();
                    }
                    else if (s != 9)
                        Console.WriteLine("Opção inválida");
                }

                else if (opcao == 3) {
                    Console.WriteLine("Você digitou a opção:" + opcao
                           + "\nSe deseja cancelar, aperte 9;" + //Opção de retornar ao menu
                           "\nPara prosseguir aperte 3 novamente");
                    s = int.Parse(Console.ReadLine());

                    if (s == 3) {

                        int Id = 1;
                        Console.WriteLine("Qual ativo deseja remover?");
                        // Para cada ativo na minha lista

                        foreach (Investimento ativo in listaativo) {
                            Console.WriteLine("Id:" + Id +
                            "Nome: " + ativo.Nome + "; Quantidade:" + ativo.Qte +
                              "; Valor Unitário: $" + ativo.VUnit.ToString("F2") + "; Valor Total = $" + (ativo.Qte * ativo.VUnit).ToString("F2") + " | " + ativo.DtHr + "\n");
                            Id++;
                        }

                        listaativo.RemoveAt(int.Parse(Console.ReadLine())-1);
                    }
                    else if (s != 9)
                        Console.WriteLine("Opção inválida");
                    Console.ReadLine();
                }

                else if (opcao == 4) {
                    Console.WriteLine("Você digitou a opção:" + opcao
                          + "\nSe deseja cancelar, aperte 9;" + //Opção de retornar ao menu
                          "\nPara prosseguir aperte 4 novamente");
                    s = int.Parse(Console.ReadLine());

                    if (s == 4) {

                        double somatorio = 0;
                        Console.WriteLine("O total de sua carteira digital é:");
                        Console.WriteLine("Nome       |    Total");

                        foreach (Investimento ativo in listaativo) {
                            Console.WriteLine(ativo.Nome + "                  " + ativo.Qte * ativo.VUnit);
                            somatorio = somatorio + (ativo.Qte * ativo.VUnit);
                        }
                        Console.WriteLine("Total Geral: $" + somatorio);
                        Console.ReadLine();
                    }
                    else if (s != 9)
                        Console.WriteLine("Opção inválida");

                }

                else if (opcao == 5) {
                    Console.WriteLine("Sair");
                }

                else {
                    Console.WriteLine("Opção inválida");
                }
            }



        }
    }
}
