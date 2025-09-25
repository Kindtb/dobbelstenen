using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace dobbelstenen_2025
{
    internal class GooierManager
    {
        public event EventHandler<Gooier> gooierIsKlaar;
        public GooierManager(Panel panel) 
        {
            Gooier gooier = new Gooier();

            int[] aantallen = new int[] { 4, 6, 8, 12, 20 };
            for (int i = 0; i<aantallen.Length; i++)
            {
                int aantal = aantallen[i];
                Button button = new Button();
                button.Text = aantal.ToString();
                button.Size = new Size(30, 30);
                button.Location = new Point(30*i, 0);
                panel.Controls.Add(button);
                // lambda function
                button.Click += (sender, e) =>
                {
                    gooier.geef(new Dobbelsteen(aantal));
                };
            }
            Button btnReset = new Button();
            btnReset.Text = "Reset";
            btnReset.Size = new Size(60, 30);
            btnReset.Location = new Point(200, 0);
            panel.Controls.Add(btnReset);
            btnReset.Click += (sender, e) => 
            {
                gooier.wisStenen();
            };
            Button btnReady = new Button();
            btnReady.Text = "Ready";
            btnReady.Size = new Size(60, 30);
            btnReady.Location = new Point(270, 0);
            panel.Controls.Add(btnReady);
            btnReady.Click += (sender, e) =>
            {
                gooierIsKlaar?.Invoke(this, gooier);
            };

        }

    }
}
