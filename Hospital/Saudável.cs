using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Saudável : Paciente
    {
        public Saudável(string nome, int idade, double peso, double altura, bool vivo, string condição)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
            Vivo = vivo;
            Condição = condição;
        }

        public void RoubarDoces()
        {
            Console.WriteLine("O coelho branco está atrasado!");
        }
    }
}
