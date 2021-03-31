using System;
using Xunit;


namespace AtivoTestes {
    public class UnitTest1 {
        [Fact]
        public void Test1() {
            var ativo1 = new Investimento();
            ativo1.Nome = "AAAA";
            ativo1.Qte = 2;
            ativo1.VUnit = 10;
            ativo1.VTotal = ativo1.Qte * ativo1.VUnit;
            ativo1.DtHr = Convert.ToString(DateTime.Now);
            var ativo2 = new Investimento();
            ativo2.Nome = "BAAA";
            ativo2.Qte = 2;
            ativo2.VUnit = 20;
            ativo2.VTotal = ativo2.Qte * ativo2.VUnit;
            ativo2.DtHr = Convert.ToString(DateTime.Now);
            listaativo.Add(ativo1);
            listaativo.Add(ativo2);
            var ativo3 = new Investimento();
            ativo3.Nome = "AAAA";
            ativo3.Qte = 2;
            ativo3.VUnit = 10;
            ativo3.VTotal = ativo3.Qte * ativo3.VUnit;
            ativo3.DtHr = Convert.ToString(DateTime.Now);
            var ativo4 = new Investimento();
            ativo4.Nome = "AAAA";
            ativo4.Qte = 2;
            ativo4.VUnit = 10;
            ativo4.VTotal = ativo4.Qte * ativo4.VUnit;
            ativo4.DtHr = Convert.ToString(DateTime.Now);
            listaativo.Add(ativo3);
            listaativo.Add(ativo4);
            listaativo.Add(ativo4);

        }
    }
}
