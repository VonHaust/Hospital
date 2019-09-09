using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Paciente : Pessoa
    {
        public string Condição { get; protected set; }

        public override void Vestir()
        {
            base.Vestir();
            Console.WriteLine("Inclui: Roupa Hospitalar.");
        }
    }
}
