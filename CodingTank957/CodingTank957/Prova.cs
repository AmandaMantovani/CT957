/*
 * 
 * Escreva uma classe em que cada objeto representa um vôo que acontece em determinada data e em determinado horário.
 * Cada vôo possui no máximo 100 passageiros, e a classe permite controlar a ocupação das cadeiras
 * (considere as cadeiras um numero inteiro de 0 a 99).
 * A classe deve ter os seguintes métodos (com o nome exato):

   OK construtor (Voo): configura os dados do vôo: aeronave, número do vôo, data e hora;
   OK AssentoDisponivel: retorna se o número da cadeira está disponivel.
   OK OcuparAssento: ocupa determinada cadeira do vôo e retorna se a operação foi bem sucedida
   OK QuantidadeVagasDisponivel: retorna o número de cadeiras vagas disponíveis (não ocupadas) no vôo
   OK ExibirInformacoesVoo: Imprime no console o conteúdo:
        “Aeronave nomeAeronave registrada sob voo de número 99 para o dia e hora 05/05/2005 01:01:01”
   OK ProximoLivre: retorna o número da próxima cadeira livre
*/

public class Voo
{
    private string Aeronave {  get; set; }
    private int NumeroVoo { get; set; }
    private DateTime DataHora { get; set; }
    private List<Cadeira> Cadeiras { get; set; }

    public Voo(string aeronave, int numeroVoo, DateTime dataHora)
    {
        this.Aeronave = aeronave;
        this.NumeroVoo = numeroVoo;
        this.DataHora = dataHora;
        this.Cadeiras = new List<Cadeira>();
        for (int i = 0; i < 100; i++)
        {
            this.Cadeiras.Add(new Cadeira(i));
        }
    }

    public bool AssentoDisponivel(int numeroCadeira)
    {
        if (numeroCadeira < 0 || numeroCadeira > 99)
        {
            Console.WriteLine("Cadeira não existe");
            return false;
        }

        //return !this.Cadeiras[numeroCadeira].Ocupado;
        //return this.Cadeiras.FirstOrDefault(c => c.NumeroAssento == numeroCadeira).Ocupado;

        //Cadeira? vaga = this.Cadeiras.FirstOrDefault(a => a.NumeroAssento == numeroCadeira &&
        //                                                  !a.Ocupado);
        //if (vaga == null)
        //{
        //    return false;
        //}
        //else
        //{
        //    return true;
        //}

        return this.Cadeiras.Any(c => c.NumeroAssento == numeroCadeira && !c.Ocupado);
    }

    public bool OcuparAssento(int numeroCadeira)
    {
        if (!AssentoDisponivel(numeroCadeira))
        {
            Console.WriteLine("Assento indisponível");
            return false;
        }
        
        //cadeira.Ocupado = true;

        this.Cadeiras[numeroCadeira].Ocupado = true;

        this.Cadeiras.FirstOrDefault(c => c.NumeroAssento == numeroCadeira).Ocupado = true;
        
        return true;
    }

    public int QuantidadeVagasDisponivel()
    {
        return this.Cadeiras.Count(c => !c.Ocupado);
        //return this.Cadeiras.Where(c => c.Ocupado == false).ToList().Count();
    }

    public void ExibirInformacoesVoo()
    {
        Console.WriteLine($"Aeronave {this.Aeronave} registrada sob voo de número {this.NumeroVoo} para o dia e hora {this.DataHora}");
    }

    public int ProximoLivre()
    {
        if (QuantidadeVagasDisponivel() == 0)
        {
            Console.WriteLine("Não há assentos disponíveis");
            return -1;
        }

        //return this.Cadeiras.FirstOrDefault(c => !c.Ocupado && c.NumeroAssento > numeroCadeira).NumeroAssento;
        //return this.Cadeiras.FirstOrDefault(c => !c.Ocupado).NumeroAssento;
        return this.Cadeiras.FindIndex(c => !c.Ocupado);

    }
}

public class Cadeira
{
    public int NumeroAssento { get; set; }
    public bool Ocupado { get; set; }
    public Cadeira(int numeroAssento)
    {
        this.NumeroAssento = numeroAssento;
        this.Ocupado = false;
    }
}
