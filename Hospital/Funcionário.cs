using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Funcionário : Pessoa
    {
        public int Ano { get; protected set; }
        public double Salário { get; protected set; }
        public string código { get; protected set; }
        public void Código() {
                if (código == "")
                {
                    Console.WriteLine("Código não identificado. A polícia será acionada em 10 segundos.");
                }
                else if (código.Length > 11)
                {
                    Console.WriteLine("O código deve conter no máximo 11 caracteres.");
                }
                else
                { 
                Console.WriteLine(código);
                }
            }

        public virtual void GanharSalário()
        {
            Console.WriteLine(Salário);
        }
    }
}
