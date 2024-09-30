using System;

namespace TreinandoPOO
{
    public abstract class Animal
    {
        public String Nome {  get; set; }
        public int Idade { get; set; }
        public String Raca { get; set; }
        public char Sexo { get; set; }

        public Animal(string nome, int idade, string raca, char sexo)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Raca = raca;
            this.Sexo = sexo;
        }

        public abstract void FazerBarulho();

        public void MostraInfo()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Idade: {this.Idade}");
            Console.WriteLine($"Raça: {this.Raca}");
            Console.WriteLine($"Sexo: {this.Sexo}");
        }
    }
}