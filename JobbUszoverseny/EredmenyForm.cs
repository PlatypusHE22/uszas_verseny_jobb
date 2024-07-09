using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JobbUszoverseny {
    public partial class EredmenyForm : Form {
        private MainForm form;
        private BindingList<Versenyzo> versenyzok;

        public EredmenyForm(MainForm form)
        {
            this.form = form;
            versenyzok = new BindingList<Versenyzo>(form.versenyzok);

            InitializeComponent();
            lbResztvevok.DataSource = versenyzok;
            lbResztvevok.DisplayMember = "Nev";
        }

        private void lbResztvevok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Versenyzo v = lbResztvevok.SelectedItem as Versenyzo;
            tbRajtszam.Text = v.Rajtszam.ToString();
            tbOrszag.Text = v.Orszag;
            tbEredmeny.Text = v.Ido.ToString();
        }

        private void rbtnNevsor_CheckedChanged(object sender, EventArgs e)
        {
            versenyzok = new BindingList<Versenyzo>(versenyzok.OrderBy(x => x.Nev).ToList());
            lbResztvevok.DataSource = versenyzok;
        }

        private void rbtnEredmeny_CheckedChanged(object sender, EventArgs e)
        {
            versenyzok = new BindingList<Versenyzo>(versenyzok.OrderBy(x => x.Ido).ToList());
            lbResztvevok.DataSource = versenyzok;
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}