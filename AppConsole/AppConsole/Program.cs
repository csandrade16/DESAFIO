﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace AppConsole {
    class Program {
        static void Main(string[] args) {
            int opcao = 0; //Variável para escolha do menu

            List<Investimento> listaativo = new List<Investimento>(); //Criação da lista a ser adicionada.

            //var ativo1 = new Investimento();
            //ativo1.Nome = "AAAA";
            //ativo1.Qte = 2;
            //ativo1.VUnit = 10;
            //ativo1.VTotal = ativo1.Qte * ativo1.VUnit;
            //ativo1.DtHr = Convert.ToString(DateTime.Now);
            //var ativo2 = new Investimento();
            //ativo2.Nome = "BAAA";
            //ativo2.Qte = 2;
            //ativo2.VUnit = 20;
            //ativo2.VTotal = ativo2.Qte * ativo2.VUnit;
            //ativo2.DtHr = Convert.ToString(DateTime.Now);
            //listaativo.Add(ativo1);
            //listaativo.Add(ativo2);
            //var ativo3 = new Investimento();
            //ativo3.Nome = "AAAA";
            //ativo3.Qte = 2;
            //ativo3.VUnit = 10;
            //ativo3.VTotal = ativo3.Qte * ativo3.VUnit;
            //ativo3.DtHr = Convert.ToString(DateTime.Now);
            //var ativo4 = new Investimento();
            //ativo4.Nome = "AAAA";
            //ativo4.Qte = 2;
            //ativo4.VUnit = 10;
            //ativo4.VTotal = ativo4.Qte * ativo4.VUnit;
            //ativo4.DtHr = Convert.ToString(DateTime.Now);
            //listaativo.Add(ativo3);
            //listaativo.Add(ativo4);
            //listaativo.Add(ativo4);


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
                        Console.WriteLine("Qual valor unitário?");
                        ativo.VUnit = double.Parse(Console.ReadLine());
                        ativo.DtHr = Convert.ToString(DateTime.Now);

                        //ativo.Nome = Investimento.Single(ativo => ativo.Nome.Equals(ativo.Nome));
                        //Console.WriteLine();

                        Console.WriteLine("Confirme as informações:");

                        ativo.ConfAdicionar();
                        listaativo.Add(ativo);
                    }
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
                }

                else if (opcao == 3) {
                    Console.WriteLine("Você digitou a opção:" + opcao
                           + "\nSe deseja cancelar, aperte 9;" + //Opção de retornar ao menu
                           "\nPara prosseguir aperte 3 novamente");
                    s = int.Parse(Console.ReadLine());

                    if (s == 3) {

                        Console.WriteLine("Qual ativo deseja remover?");
                        
                        // Para cada ativo na minha lista

                        foreach (Investimento ativo in listaativo) {
                            int Id = 1;
                            Id++;
                            ativo.ConfRemover();                            
                        }
                        listaativo.RemoveAt(int.Parse(Console.ReadLine()));
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

                        foreach (Investimento ativo in listaativo) {
                            Console.WriteLine(ativo.Nome + "                  " + ativo.Qte * ativo.VUnit);
                            somatorio = somatorio + (ativo.Qte * ativo.VUnit);
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
