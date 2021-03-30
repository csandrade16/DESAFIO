using System;
using System.Globalization;
using System.Collections.Generic;

namespace AppConsole {
    class Program {
        static void Main(string[] args) {
            int opcao = 0; //Variável para escolha do menu

            List<Investimento> listap = new List<Investimento>(); //Criação da lista a ser adicionada.

            while (opcao != 5) { //Fórmula quando o usuário digitar algo  errado


                Console.WriteLine("Bem - vindo(a) a sua Carteira de Investimentos!\n" +
                        "Aplicativo feito para você Investidor!\n" +
                        "Nesse APP voce pode ter uma visao global dos seus investimentos\n" +
                        "Utilize as nossas interações e acompanhe sua carteira:\n\n"); //Mensagem de inicialização

                Console.Write("Digite 1 - Para registrar a compra de um novo ativo na carteira\n" +
                        "Digite 2 - Para visualizar a lista de ativos investidos\n" +
                        "Digite 3 - Para informar a venda de seus ativos\n" +
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

                    Investimento p = new Investimento();

                    if (s == 1) {

                        Console.Clear();
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
                                          + "; Quantidade:"
                                          + p.Qte
                                          + "; Valor Unitário:"
                                          + p.VUnit
                                          + "; Valor Total ="
                                          + p.Qte * p.VUnit
                                          + "\n");
                        listap.Add(p);
                    }
                }


                else if (opcao == 2) {
                    Console.WriteLine("Você digitou a opção:" + opcao
                            + "\nSe deseja cancelar, aperte 9;" + //Opção de retornar ao menu
                            "\nPara prosseguir aperte 2 novamente");
                    s = int.Parse(Console.ReadLine());

                    if (s == 2) {
                        Console.WriteLine("Veja seu extrato a seguir:");

                        foreach (Investimento p in listap) {
                            Console.WriteLine("Nome:" + p.Nome + "; Quantidade:" + p.Qte + "; Valor Unitário: R$" + p.VUnit + ";Total: R$" + (p.Qte * p.VUnit) + "|" + p.DtHr);
                        }
                        Console.ReadLine();
                    }
                }

                else if (opcao == 3) {
                    Console.WriteLine("Você digitou a opção:" + opcao
                           + "\nSe deseja cancelar, aperte 9;" + //Opção de retornar ao menu
                           "\nPara prosseguir aperte 3 novamente");
                    s = int.Parse(Console.ReadLine());

                    if (s == 3) {

                        Console.WriteLine("Qual ativo deseja remover?");
                        int indice = 1;
                        // Para cada ativo na minha lista

                        foreach (Investimento p in listap) {
                            Console.WriteLine("ID:" + indice + "Nome:" + p.Nome
                                + "; Quantidade:" + p.Qte
                                + "; Valor Unitário: R$" + p.VUnit
                                + "; Total: R$" + (p.Qte * p.VUnit));
                            indice++;
                        }
                        listap.RemoveAt(int.Parse(Console.ReadLine()));
                    }
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

                        foreach (Investimento p in listap) {
                            Console.WriteLine(p.Nome + "                  " + p.Qte * p.VUnit);
                            somatorio = somatorio + (p.Qte * p.VUnit);
                        }
                        Console.WriteLine("Total Geral:" + somatorio);
                        Console.ReadLine();
                    }
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
