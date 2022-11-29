using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank957
{
    public class Pessoa1
    {
        //atributo
        private string nome;
        //propriedade
        public string Nome
        { 
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        //evita getNome(), setNome()

        //propriedade automatica
        private List<Animal1> Animais { get; set; }

        //construtor
        public Pessoa1(string nome)
        {
            Nome = nome;
            Animais = new List<Animal1>();
        }

        //encapsulamento
        public void AdicionarAnimal(Animal1 animal)
        {
            Animais.Add(animal);
        }

        //encapsulamento
        public bool DeclararMorte(string nomeAnimal)
        {
            var animal = Animais.FirstOrDefault(x => x.Nome == nomeAnimal);
            if (animal == null)
            {
                return false;
            }

            animal.Vivo = false;
            return true;
        }
        
        //métodos
        public List<string> EspecieAnimais()
        {
            return Animais.DistinctBy(x => x.Especie).Select(x => x.Especie).ToList();
        }

        public List<Animal1> RetornaAnimaisPorEspecie(string especie)
        {
            return Animais.Where(x => x.Especie == especie).ToList();
        }

        public bool PossuiEspecie(string especie)
        {
            return Animais.Any(x => x.Especie == especie);
        }
    }

    public class Animal1
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public bool Vivo { get; set; }
        public Animal1(string nome, string especie)
        {
            Nome = nome;
            Especie = especie;
            Vivo = true;
        }
    }

}
