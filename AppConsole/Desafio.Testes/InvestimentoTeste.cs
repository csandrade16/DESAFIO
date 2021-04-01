using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace Desafio.Testes {
    [TestClass]
    public class InvestimentoTeste {

        //[metodo]_[condicao]_[resultadoEsperado]

        [TestMethod]
        public void DadosAddAtivo_QdoObterNovoInvestimento_RetornarInvestimento() {

            //Arrange
            Investimento ativo = new Investimento();
            ativo.Nome = "STNE";
            ativo.Qte = 10;
            ativo.VUnit = 10;
            ativo.VTotal = ativo.Qte * ativo.VUnit;
            ativo.DtHr = Convert.ToString(DateTime.Now);


            string resultadoEsperado = "Nome: STNE; Quantidade: 10; Valor Unitário: $ 10; Valor Total = $100";

            //Act
            string resultadoAtual = "Nome: " + ativo.Nome + "; Quantidade: " + ativo.Qte +
                "; Valor Unitário: $ " + ativo.VUnit + "; Valor Total = $" + ativo.VTotal;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void DadosExtratoInvestimeno_MostrarInvestimento_RetornarTodos() {

            List<Investimento> listaativo = new List<Investimento>();

            //Arrange
            var ativo1 = new Investimento();


            ativo1.Nome = "STNE";
            ativo1.Qte = 10;
            ativo1.VUnit = 10;
            ativo1.VTotal = ativo1.Qte * ativo1.VUnit;
            ativo1.DtHr = Convert.ToString(DateTime.Now);

            var ativo2 = new Investimento();
            ativo2.Nome = "GOOG";
            ativo2.Qte = 2;
            ativo2.VUnit = 30;
            ativo2.VTotal = ativo2.Qte * ativo2.VUnit;
            ativo2.DtHr = Convert.ToString(DateTime.Now);

            var ativo3 = new Investimento();
            ativo3.Nome = "PGRM";
            ativo3.Qte = 2;
            ativo3.VUnit = 20;
            ativo3.VTotal = ativo3.Qte * ativo3.VUnit;
            ativo3.DtHr = Convert.ToString(DateTime.Now);

            listaativo.Add(ativo1);
            listaativo.Add(ativo2);
            listaativo.Add(ativo3);


            string resultadoEsperado = ("Nome: STNE; Quantidade: 10; Valor Unitário: $ 10; Valor Total = $100 | " + ativo1.DtHr + "\n") +
                                       ("Nome: GOOG; Quantidade: 2; Valor Unitário: $ 30; Valor Total = $60 | " + ativo2.DtHr + "\n") +
                                       "Nome: PGRM; Quantidade: 2; Valor Unitário: $ 20; Valor Total = $40 | " + ativo3.DtHr + "\n";

            //Act
            string resultadoAtual = "Nome: " + ativo1.Nome + "; Quantidade: " + ativo1.Qte +
                "; Valor Unitário: $ " + ativo1.VUnit + "; Valor Total = $" + ativo1.VTotal + " | " + ativo1.DtHr + "\n" +
                "Nome: " + ativo2.Nome + "; Quantidade: " + ativo2.Qte +
                "; Valor Unitário: $ " + ativo2.VUnit + "; Valor Total = $" + ativo2.VTotal + " | " + ativo2.DtHr + "\n" +
                "Nome: " + ativo3.Nome + "; Quantidade: " + ativo3.Qte +
                "; Valor Unitário: $ " + ativo3.VUnit + "; Valor Total = $" + ativo3.VTotal + " | " + ativo3.DtHr + "\n";

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void DadosRemover_MostrarIndice_RemoverAtivo() {

            List<Investimento> listaativo = new List<Investimento>();

            //Arrange
            var ativo1 = new Investimento();

            int Id = 0;
            ativo1.Id = ++Id;
            ativo1.Nome = "STNE";
            ativo1.Qte = 10;
            ativo1.VUnit = 10;
            ativo1.VTotal = ativo1.Qte * ativo1.VUnit;
            ativo1.DtHr = Convert.ToString(DateTime.Now);

            var ativo2 = new Investimento();
            ativo2.Id = ++Id;
            ativo2.Nome = "GOOG";
            ativo2.Qte = 2;
            ativo2.VUnit = 30;
            ativo2.VTotal = ativo2.Qte * ativo2.VUnit;
            ativo2.DtHr = Convert.ToString(DateTime.Now);

            var ativo3 = new Investimento();
            ativo3.Id = ++Id;
            ativo3.Nome = "PGRM";
            ativo3.Qte = 2;
            ativo3.VUnit = 20;
            ativo3.VTotal = ativo3.Qte * ativo3.VUnit;
            ativo3.DtHr = Convert.ToString(DateTime.Now);

            listaativo.Add(ativo1);
            listaativo.Add(ativo2);
            listaativo.Add(ativo3);

            listaativo.RemoveAt(2);
            string resultadoEsperado = ("Id: 1; Nome: STNE; Quantidade: 10; Valor Unitário: $ 10; Valor Total = $100 | " + ativo1.DtHr + "\n") +
                                       ("Id: 3; Nome: PGRM; Quantidade: 2; Valor Unitário: $ 20; Valor Total = $40 | " + ativo3.DtHr + "\n");

            //Act
            foreach (Investimento ativo in listaativo) {
                Console.WriteLine(("Nome: " + ativo.Nome + "; Quantidade: " + ativo.Qte +
                    "; Valor Unitário: $ " + ativo.VUnit + "; Valor Total = $" + ativo.VTotal + " | " + ativo.DtHr + "\n"));
            }
            string resultadoAtual = ("Id: "+ ativo1.Id+ "; Nome: " + ativo1.Nome + "; Quantidade: " + ativo1.Qte +
                    "; Valor Unitário: $ " + ativo1.VUnit + "; Valor Total = $" + ativo1.VTotal + " | " + ativo1.DtHr + "\n") + 
                    ("Id: " + ativo3.Id + "; Nome: " + ativo3.Nome + "; Quantidade: " + ativo3.Qte +
                    "; Valor Unitário: $ " + ativo3.VUnit + "; Valor Total = $" + ativo3.VTotal + " | " + ativo3.DtHr + "\n");


            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }





        public class Investimento {

            private double _somatorio; // Variavel do valor total investido

            public string Nome; // Variavel do nome do ativo
            public int Id { get; set; } // Identificação do ativo na lista
            public int Qte { get; set; } // Variavel da quantidade do ativo adquirida
            public double VUnit { get; set; } // Variavel do valor unitário de cada ação
            public string DtHr { get; set; } // Variavel da data/hora do registro
            public double VTotal { get; set; } // Variavel do valor total do ativo
            public int opcao { get; set; }

            
            public Investimento() {

            }

        }
    }
}


