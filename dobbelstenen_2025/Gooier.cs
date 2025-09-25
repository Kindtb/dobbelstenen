using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobbelstenen_2025
{
    internal class Gooier
    {
        public List<Dobbelsteen> dobbelstenen = new List<Dobbelsteen>();
        Random randomGenerator = new Random();

        public void geef(Dobbelsteen dobbelsteen)
        {
            dobbelstenen.Add(dobbelsteen);
            Console.WriteLine($"ik heb nu {dobbelstenen.Count} dobbelstenen");
        }
        public void wisStenen()
        {
            dobbelstenen.Clear();
            Console.WriteLine($"ik heb nu {dobbelstenen.Count} dobbelstenen");
        }
        public int gooi()
        {
            int aantalOgen = 0;

            foreach (Dobbelsteen dobbelsteen in dobbelstenen)
            {
                aantalOgen += randomGenerator.Next(1, dobbelsteen.aantalVlakken + 1);
            }
            return aantalOgen;
        }

        public int getAantalDobbelstenen()
        {
            return dobbelstenen.Count;
        }
        public int getMaximumAantalOgen()
        {
            int maximum = 0;
            foreach (Dobbelsteen dobbelsteen in dobbelstenen)
            {
                maximum += dobbelsteen.aantalVlakken;
            }

            return maximum;
        }


    }
}
