using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JobbUszoverseny {
    public partial class VersenyForm : Form {
        private List<Versenyzo> versenyzok;
        private int index = 0;
        private Form1 form;

        public VersenyForm(List<Versenyzo> versenyzok, Form1 form)
        {
            this.versenyzok = versenyzok;
            InitializeComponent();
            tbVersenyzo.ReadOnly = true;
            this.form = form;
            mtbEredmeny.Clear();

            LoadVersenyzo(0);
            index++;
        }

        void LoadVersenyzo(int i)
        {
            tbVersenyzo.Text = versenyzok[i].Nev;
            mtbEredmeny.Clear();
        }

        private void Save()
        {
            form.versenyzok = versenyzok;
            form.menuEredmeny.Enabled = true;
            Close();
        }

        private void btnKovetkezo_Click(object sender, EventArgs e)
        {
            // Megadott adatok elemntése
            string[] t = mtbEredmeny.Text.Split(':');
            versenyzok[index].Ido = new TimeSpan(0, 0, int.Parse(t[0]), int.Parse(t[1]), int.Parse(t[2]));
            // Következő versenyző betöltése
            if (index >= versenyzok.Count)
            {
                btnKovetkezo.Enabled = false;
                if (!btnVerseny.Enabled)
                {
                    Save();
                }
            }
            else
                LoadVersenyzo(index);

            index++;
        }


        private void btnVerseny_Click(object sender, EventArgs e)
        {
            Form1.VersenyTav = int.Parse(numTav.Text);
            Form1.VersenyFajta = comboFajta.SelectedItem.ToString();

            btnVerseny.Enabled = false;
            numTav.Enabled = false;
            comboFajta.Enabled = false;

            if (!btnKovetkezo.Enabled)
            {
                Save();
            }
        }

    }
}