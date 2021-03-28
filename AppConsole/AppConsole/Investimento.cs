namespace AppConsole {
    class Investimento {

        private string _nome; // Variavel do nome do ativo
        private double _vTotal() { // Variavel do valor total do ativo
            return Qte * VUnit;
        }
        private double _somatorio; // Variavel do valor total investido

        public int Id { get; set; } // Identificação do ativo na lista
        public int Qte { get; set; } // Variavel da quantidade do ativo adquirida
        public double VUnit { get; set; } // Variavel do valor unitário de cada ação
        public string DtHr { get; set; } // Variavel da data/hora do registro

        public Investimento() {
        }
        public Investimento(string nome, double vtotal) {
            _nome = nome;
        }

        /*public void Setvtotal(double vtotal) {
            bool v = vtotal != null;
            if (v) {
                _vTotal = vtotal;
            }

        }*/

        public string GetNome() {
            return _nome;
        }
        public void SetNome(string nome) { // Condição para que o nome do ativo correto
            if (nome != null && nome.Length > 1 && nome.Length < 4) {
                _nome = nome;
            }

        }

        public void AdicionarAtivos(int quantidade) {// Método adicionar ativos

        }
        public void RemoverAtivos(int quantidade) {// Método remover ativos

        }
    }
}
