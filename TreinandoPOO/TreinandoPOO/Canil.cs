using System;

namespace TreinandoPOO
{
    public class Canil
    {
        List<Cachorro> cachorros = new List<Cachorro>();

        public void AddCachorro(Cachorro cachorro)
        {
            cachorros.Add(cachorro);
        }

        public void ExibirCachorros()
        {
            foreach (Cachorro cachorro in cachorros)
            {
                cachorro.MostraInfo();
                Console.WriteLine("----------");
            }
        }

        public void AtualizarCachorro(int indice, Cachorro cachorro)
        {
            cachorros[indice] = cachorro;
        }

        public void DeletarCachorro(int indice)
        {
            cachorros.RemoveAt(indice);
        }
    }
}