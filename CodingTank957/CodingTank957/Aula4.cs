namespace CodingTank957
{
    public class Aula4
    {
        static void MainA4(string[] args)
        {
            Pessoa pessoa1 = new Pessoa()
            {
                Nome = "amanda",
                Idade = 28
            };

            pessoa1.Idade = 28;

            Animal cachorro1 = new Animal("lassy", "cachorro");
            bool sucesso = pessoa1.AdicionarAnimal(cachorro1);
            if (sucesso)
            {
                //cirurgia
            }

            pessoa1.AdicionarAnimal(new Animal("bolinha", "cachorro"));
            pessoa1.AdicionarAnimal(new Animal("toddy", "gato"));

            List<string> especies = pessoa1.EspecieAnimais();

            Console.WriteLine(string.Join(", ", especies));
        }
    }
}
