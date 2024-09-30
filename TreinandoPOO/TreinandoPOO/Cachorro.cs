using System;

namespace TreinandoPOO
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade, string raca, char sexo) : base (nome, idade, raca, sexo) { }

        public override void FazerBarulho()
        {
            Console.WriteLine("Au Au");
        }
    }
}