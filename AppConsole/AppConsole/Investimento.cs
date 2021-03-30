namespace AppConsole {
    class Investimento {



        private double _somatorio; // Variavel do valor total investido
        public string Nome; // Variavel do nome do ativo
        public int Id { get; set; } // Identificação do ativo na lista
        public int Qte { get; set; } // Variavel da quantidade do ativo adquirida
        public double VUnit { get; set; } // Variavel do valor unitário de cada ação
        public string DtHr { get; set; } // Variavel da data/hora do registro
        public double VTotal { get; set; } // Variavel do valor total do ativo



        public Investimento() {

        }
        public Investimento(string Nome, double qte, double VUnit, string DtHr) {

        }
        public Investimento(string Nome, double vtotal) {
        }
    }
}
