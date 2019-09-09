using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Enfermeiro : Funcionário
    {
        public string InstrumentoCirurgico { get; protected set; }
        public bool Bullying { get; protected set; }

        public void ExílioEstatal()
        {
            if (Bullying == true)
            {
                Console.WriteLine("Indivíduo Deportado.");
            }
            else
            {

            }
        }

        public override void Vestir()
        {
            base.Vestir();
            Console.WriteLine("Inclui: Jaleco Bege.");
        }
        public override void GanharSalário()
        {
            Console.WriteLine(Salário = 3092);
        }
        public Enfermeiro(string nome, int idade, double peso, double altura, bool vivo, int ano, string cod, string instrumento, bool bully)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
            Vivo = vivo;
            Ano = ano;
            código = cod;
            InstrumentoCirurgico = instrumento;
            Bullying = bully;
        }
    }
}
