using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Recepcionista : Funcionário
    {
        public int DDD { get; protected set; }

        public override void Vestir()
        {
            base.Vestir();
            Console.WriteLine("Inclui: Boina.");
        }

        public override void GanharSalário()
        {
            Console.WriteLine(Salário = 998);
        }

        public Recepcionista(string nome, int idade, double peso, double altura, bool vivo, int ano, string cod, int ddd)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
            Vivo = vivo;
            Ano = ano;
            código = cod;
            DDD = ddd;
        }
    }
}
