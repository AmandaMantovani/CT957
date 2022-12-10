namespace CodingTank957
{
    public  class MainProva
    {
        static void Main(string[] args)
        {
            Voo voo1 = new Voo("Teste ada", 150, DateTime.Now);

            Console.WriteLine($"Proximo livre, deve ser 0: {voo1.ProximoLivre()}");
            voo1.OcuparAssento(1);

            Console.WriteLine($"Proximo livre, deve ser 0: {voo1.ProximoLivre()}");
            voo1.OcuparAssento(0);
            voo1.OcuparAssento(5);
            voo1.OcuparAssento(2);
            voo1.OcuparAssento(15);
            voo1.OcuparAssento(15);

            Console.WriteLine($"Proximo livre, deve ser 3: {voo1.ProximoLivre()}");

            Console.WriteLine($"Quantidade vagas, deve ser 95: {voo1.QuantidadeVagasDisponivel()}");
            Console.WriteLine($"Quantidade vagas, deve ser 95: {voo1.QuantidadeVagasDisponivel()}");

            Console.WriteLine($"Assento 1 disponivel, deve ser false: {voo1.AssentoDisponivel(1)}");

            Console.WriteLine($"Assento 15 disponivel, deve ser false: {voo1.AssentoDisponivel(15)}");

            Console.WriteLine($"Assento 30 disponivel, deve ser true: {voo1.AssentoDisponivel(30)}");

            voo1.ExibirInformacoesVoo();
        }
        /*
        static void Main(string[] args)
        {
            Voo voo1 = new Voo("Teste ada", 150, DateTime.Now);

            Console.WriteLine($"Proximo livre, deve ser 0: ");
            voo1.ProximoLivre();
            voo1.OcuparAssento(1);

            Console.WriteLine($"Proximo livre, deve ser 0: ");
            voo1.ProximoLivre();
            voo1.OcuparAssento(0);
            voo1.OcuparAssento(5);
            voo1.OcuparAssento(2);
            voo1.OcuparAssento(15);

            Console.WriteLine($"Proximo livre, deve ser 3: ");
            voo1.ProximoLivre();

            Console.WriteLine($"Quantidade vagas, deve ser 95: ");
            voo1.QuantidadeVagasDisponivel();
            voo1.QuantidadeVagasDisponivel();

            Console.WriteLine($"Assento 1 disponivel, deve ser false: ");
            voo1.AssentoDisponivel(1);

            Console.WriteLine($"Assento 15 disponivel, deve ser false: ");
            voo1.AssentoDisponivel(15);

            Console.WriteLine($"Assento 30 disponivel, deve ser true: ");
            voo1.AssentoDisponivel(30);

            voo1.ExibirInformacoesVoo();
        }
        */
    }

}
