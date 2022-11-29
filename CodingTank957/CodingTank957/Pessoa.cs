using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank957
{
    public class Pessoa
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

        //propriedade automatica
        public int Idade { get; set; }

        private List<Animal> Animais { get; set; }

        //construtor vazio
        public Pessoa()
        {
            this.Animais = new List<Animal>();
        }

        //construtor com nome obrigatorio
        public Pessoa(string nome)
        {
            this.Nome = nome;
            this.Animais = new List<Animal>();
        }

        //construtor com todos as propriedades obrigatorios
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Animais = new List<Animal>();
        }

        //encapsulamento
        public bool AdicionarAnimal(Animal animal)
        {
            if (animal.Especie == "Ave")
            {
                Console.WriteLine("Não aceitamos aves");
                return false;
            }

            this.Animais.Add(animal);
            return true;
        }

        public bool DeclararMorteDeAnimal(string nomeAnimal, string especie)
        {
            Animal? animal = this.Animais.FirstOrDefault(a =>
                                            a.Nome == nomeAnimal &&
                                            a.Especie == especie);
            if (animal == null)
            {
                return false;
            }

            animal.Vivo = false;
            return true;
        }

        public List<string> EspecieAnimais()
        {
            //IEnumerable
            //List<Animal> var1 = this.Animais.DistinctBy(a => a.Especie).ToList();
            //List<string> var2 = var1.Select(a => a.Especie).ToList();
            //return var2;

            return this.Animais.Select(a => a.Especie).Distinct().ToList();
        }

        public List<Animal> RetornarAnimaisDaEspecie(string especie)
        {
            return this.Animais.Where(a => a.Especie == especie).ToList();
        }

        public bool PossuiEspecie(string especie)
        {
            return this.Animais.Any(a => a.Especie == especie);
        }
        
        //this.Animais.Remove(animal); // remove o objeto
        //this.Animais.RemoveAt(0); // remove a partir do index
        //this.Animais.Add(new Animal()); // adiciona objeto na lista
        //this.Animais.AddRange(new List<Animal>()); // adiciona objetos de uma lista na lista
        //this.Animais.Insert(index, new Animal()); // adiciona na posição especifica
        //this.Animais.Count(); // retorna total de objetos - numero
        //this.Animais.OrderBy(x => x.Especie); // retorna uma lista ordenada
    }

    public class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public bool Vivo { get; set; }
        public Animal(string nome, string especie)
        {
            this.Nome = nome;
            this.Especie = especie;
            this.Vivo = true;
        }
    }
}
