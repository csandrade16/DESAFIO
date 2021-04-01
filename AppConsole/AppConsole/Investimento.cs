
namespace AppConsole {
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
        public Investimento(string Nome, int Qte, double VUnit, string DtHt) {

        }

        public Investimento(string Nome) {
        }

        public string Adicionar() {
            return string.Format(
                $"Nome: " + Nome + "; Quantidade: " + Qte +
                "; Valor Unitário: $ " + VUnit.ToString("F2") + "; Valor Total = $" + (Qte * VUnit).ToString("F2")) + " | " + DtHr + "\n";
        }

        public void ConfAdicionar() {
            System.Console.WriteLine(Adicionar());
        }

        public string Remover() {
            return string.Format(
                "Id:" + ++(Id) +
                "Nome: " + Nome + "; Quantidade:" + Qte +
                "; Valor Unitário: $" + VUnit.ToString("F2") + "; Valor Total = $" + (Qte * VUnit).ToString("F2") + " | " + DtHr + "\n");
        }

        public void ConfRemover() {
            System.Console.WriteLine(Remover());
        }

        public string Extrato() {
            return string.Format(
                "Nome: " + Nome + "; Quantidade:" + Qte +
                "; Valor Unitário: $" + VUnit.ToString("F2") + "; Valor Total = $" +
                (Qte * VUnit).ToString("F2") + " | " + DtHr + "\n");
        }
        public void ExtratonoConsole() {
            System.Console.WriteLine(Extrato());
        }



        //Investimento ativo1 = new Investimento("STNE", 2, 62.16, Convert.ToString(DateTime.Now));
        //Investimento ativo2 = new Investimento("CSCO", 1, 51.71, Convert.ToString(DateTime.Now));
        //Investimento ativo3 = new Investimento("EBAY", 1, 62.50, Convert.ToString(DateTime.Now));

        //listaativo.Add(ativo1);
        //listaativo.Add(ativo2);
        //listaativo.Add(ativo3);
    }
}
