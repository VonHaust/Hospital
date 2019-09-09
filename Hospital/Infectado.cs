using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Infectado : Paciente
    {
        public Infectado(string nome, int idade, double peso, double altura, bool vivo, string condição)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
            Vivo = vivo;
            Condição = condição;
        }
    }
}
