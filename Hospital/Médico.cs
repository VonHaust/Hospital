using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Médico : Funcionário
    {
        public int Sala { get; protected set; }
        public string Faixa { get; protected set; }

        public override void GanharSalário()
        {
            Console.WriteLine(Salário = 10780);
        }

        public override void Vestir()
        {
            base.Vestir();
            Console.WriteLine("Inclui: Jaleco Branco");
        }

        public Médico(string nome, int idade, double peso, double altura, bool vivo, int ano, string cod, int sala, string faixa)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
            Vivo = vivo;
            Ano = ano;
            código = cod;
            Sala = sala;
            Faixa = faixa;
        }
    }
}
