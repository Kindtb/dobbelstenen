using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dobbelstenen_2025
{
    internal class Waarnemer
    {
        private Gooier gooier;
        int[] resultaten;
        int aantalWaarnemingen;

        public Waarnemer(Gooier gooier)
        {
            this.gooier = gooier;
            resultaten = new int[gooier.getMaximumAantalOgen() + 1];
        }

        public void tel(int aantal)
        {
            this.aantalWaarnemingen = aantal;
            resultaten = new int[gooier.getMaximumAantalOgen() + 1];
            for (int i=0; i<aantal; i++)
            {
                int resultaat = gooier.gooi();
                resultaten[resultaat] += 1;

            }
        }

        public void toonResultaat(TextBox textBox)
        {
            string output = "";
            for(int resultaat=gooier.getAantalDobbelstenen(); resultaat<resultaten.Length; resultaat++)
            {
                float percentage = (float)resultaten[resultaat] / aantalWaarnemingen;
                output += $"{resultaat}\t{resultaten[resultaat]}\t{100*percentage}%\r\n";
            }

            textBox.Text = output;
        }
    }
}
