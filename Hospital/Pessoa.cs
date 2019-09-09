using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Pessoa
    {
        public string Nome { get; protected set; }
        public bool Vivo { get; protected set; }
        public int Idade { get; protected set; }
        public double Peso { get; protected set; }
        public double Altura { get; protected set; }

        public void Viver()
        {
            Vivo = true;
        }

        public void Morrer()
        {
            Vivo = false;
            Console.WriteLine("O indivíduo foi procurar pão alto demais.");
        }

        public void Sorrir()
        {
            Console.WriteLine("Humanos fazem um gesto com a boca quando estão felizes ex: :D");
        }
        public void Pensar()
        {
            Console.WriteLine("Thronk");
        }

        public virtual void Vestir()
        {
            Console.WriteLine("Inclui: Roupas íntimas.");
        }
    }
}
