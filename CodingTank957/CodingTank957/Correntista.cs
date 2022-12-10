namespace CodingTank957
{
    public class Correntista
    {
        private decimal Saldo { get; set; }
        public string Cpf { get; set; }
        private List<Despesa> Despesas { get; set; }

        public Correntista(string cpf)
        {
            this.Cpf = cpf;
            this.Despesas = new List<Despesa>();
        }

        public decimal BuscarValorSaldo()
        {
            return this.Saldo;
        }

        public void AdicionarSaldo(decimal valor)
        {
            this.Saldo += valor;
        }

        public bool PagarConta(decimal valor)
        {
            if (this.Saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente para completar a transação.");
                return false;
            }
            Saldo -= valor;
            return true;
        }

        public void InserirDespesa(Despesa despesa)
        {
            this.Despesas.Add(despesa);
        }

        public decimal SomarDespesas()
        {
            return this.Despesas.Sum(x => x.Valor);
        }
        public Correntista EncontrarCorrentista(List<Correntista> correntistas, string cpf)
        {
            return correntistas.FirstOrDefault(x => x.Cpf == cpf);
        }
    }
    public class Despesa
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public Despesa(string descricao, decimal valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}
