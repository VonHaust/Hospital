using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Médico MisterM = new Médico ("Roman", 30, 79.3, 1.78, true, 2016, "109876543211", 1, "Elastic Heart");
            MisterM.Código();
            MisterM.GanharSalário();
            MisterM.Vestir();

            Enfermeiro James = new Enfermeiro ("James", 27, 66, 1.73, true, 2018, "93849", "Mewtwo", false);
            James.Vestir();
            James.GanharSalário();
            James.ExílioEstatal();

            Enfermeiro Jessie = new Enfermeiro ("Jessie", 26, 57, 1.68, true, 2018, "93855", "Meowth", true);
            Jessie.Vestir();
            Jessie.GanharSalário();
            Jessie.ExílioEstatal();

            Recepcionista Aladdin = new Recepcionista ("Aladdin", 12, 49.2, 1.3, true, 2017, "00050", 84);
            Aladdin.Vestir();
            Aladdin.GanharSalário();

            Infectado Leon = new Infectado("Leon", 22, 70.6, 1.88, false, "Grave");
            Leon.Morrer();

            Saudável Alice = new Saudável("Alice", 17, 59.4, 1.63, true, "Regular");
            Alice.RoubarDoces();

            Console.ReadKey();
        }
    }
}
