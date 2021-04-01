using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            string resultadoAtual = "Nome: " + ativo.Nome + "; Quantidade:" + ativo.Qte +
                "; Valor Unitário: $" + ativo.VUnit + "; Valor Total = $" + ativo.VTotal;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
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

        public Investimento(string Nome, int Qte, double Vunit, double VTotal, string DtHr) {

        }
        public Investimento() {

        }

    }
}


