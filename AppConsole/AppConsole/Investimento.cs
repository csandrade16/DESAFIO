
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

        public Investimento(string Nome) {
        }

        public string Adicionar() {
            return string.Format (
                $"Nome: " + Nome + "; Quantidade:" + Qte +
                "; Valor Unitário:" + VUnit + "; Valor Total =" + (Qte * VUnit)) +" | "+ DtHr +"\n";
        }

        public void ConfAdicionar() {
            System.Console.WriteLine(Adicionar());
        }

        public string Remover() {
            return string.Format(
                "Id:"+ Id +
                "Nome: " + Nome + "; Quantidade:" + Qte +
                "; Valor Unitário:" + VUnit + "; Valor Total =" + (Qte * VUnit) + " | " + DtHr + "\n");
        }

        public void ConfRemover() {
            System.Console.WriteLine(Remover());
        }

        public string Extrato() {
            return string.Format(
                "Nome: " + Nome + "; Quantidade:" + Qte +
                "; Valor Unitário:" + VUnit + "; Valor Total =" + 
                (Qte * VUnit) + " | " + DtHr + "\n");
        }
        public void ExtratonoConsole() {
            System.Console.WriteLine(Extrato());
        }

    }
}
