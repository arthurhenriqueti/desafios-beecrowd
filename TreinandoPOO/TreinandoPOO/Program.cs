using System;

namespace TreinandoPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Canil canil = new Canil();

            Cachorro cachorro1 = new Cachorro("Fred", 5, "Poodle", 'M');
            Cachorro cachorro2 = new Cachorro("Luly", 10, "Poodle", 'F');
            Cachorro cachorro3 = new Cachorro("Max", 2, "PitBull", 'M');
            Cachorro cachorro4 = new Cachorro("Nina", 7, "Dalmata", 'F');
            Cachorro cachorro5 = new Cachorro("Tyler", 1, "Vira-lata", 'M');

            canil.AddCachorro(cachorro1);
            canil.AddCachorro(cachorro2);
            canil.AddCachorro(cachorro3);
            canil.AddCachorro(cachorro4);
            canil.AddCachorro(cachorro5);

            canil.ExibirCachorros();

            Cachorro cachorro6 = new Cachorro("Bruce", 8, "Vira-lata", 'M');
            canil.AtualizarCachorro(4, cachorro6);

            canil.ExibirCachorros();

            canil.DeletarCachorro(0);
            canil.ExibirCachorros();
        }
    }
}