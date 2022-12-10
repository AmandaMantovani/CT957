using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank957
{
    public class CorrentistaMain
    {
        static void MainCorrentista(string[] args)
        {
            Correntista correntista1 = new Correntista("123456789");
            
            correntista1.AdicionarSaldo(100);
            
            decimal saldoAtual = correntista1.BuscarValorSaldo();
            Console.WriteLine($"Saldo atual: {saldoAtual}");

            correntista1.PagarConta(150);

            correntista1.PagarConta(50);

            saldoAtual = correntista1.BuscarValorSaldo();
            Console.WriteLine($"Saldo atual: {saldoAtual}");

            correntista1.InserirDespesa(new Despesa("Conta de agua", 150));
            correntista1.InserirDespesa(new Despesa("Conta de luz", 80));

            decimal totalDespesas = correntista1.SomarDespesas();
            Console.WriteLine($"Total despesas: {totalDespesas}");

            var lista = new List<Correntista>();
            lista.Add(correntista1);

            var correntistaBusca = EncontrarCorrentista(lista, "123456789");
            if (correntistaBusca != null)
            {
                Console.WriteLine("Correntista encontrado!");
            }

            correntistaBusca = correntista1.EncontrarCorrentista(lista, "123456789");
            if (correntistaBusca != null)
            {
                Console.WriteLine("Correntista encontrado!");
            }

        }

        public static Correntista EncontrarCorrentista(List<Correntista> correntistas, string cpf)
        {
            return correntistas.FirstOrDefault(x => x.Cpf == cpf);
        }

    }
}
