using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Size = new Size(300, 500);
            textBox.Location = new Point(0, 50);
            textBox.ScrollBars = ScrollBars.Vertical;
            Controls.Add(textBox);
            TextBox textBox2 = new TextBox();
            textBox2.Multiline = true;
            textBox2.Size = new Size(300, 500);
            textBox2.Location = new Point(300, 50);
            textBox2.ScrollBars = ScrollBars.Vertical;
            Controls.Add(textBox2);
            Panel panel = new Panel();
            panel.Size = new Size(600, 50);
            Controls.Add(panel);


            GooierManager gooierManager = new GooierManager(panel);
            /*
            gooierManager.gooierIsKlaar += (sender, gooier) =>
            {
                Waarnemer waarnemer = new Waarnemer(gooier);
                waarnemer.tel(1000000);
                waarnemer.toonResultaat(textBox);

                waarnemer.tel(1000000);
                waarnemer.toonResultaat(textBox2);
            };
            */
        }
    }
}
