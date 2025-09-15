using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dobbelstenen_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dobbelsteen dobbelsteen1 = new Dobbelsteen(6);
            Dobbelsteen dobbelsteen2 = new Dobbelsteen(20);

            Gooier gooier = new Gooier();
            gooier.geef(dobbelsteen1);
            gooier.geef(dobbelsteen2);
            gooier.geef(new Dobbelsteen(6));

            TextBox textBox = new TextBox();
            textBox.Multiline = true;

            Waarnemer waarnemer = new Waarnemer(gooier);
            waarnemer.tel(1000);
            waarnemer.toonResultaat(textBox);
        }
    }
}
