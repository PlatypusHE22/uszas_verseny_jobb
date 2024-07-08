using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobbUszoverseny {
    public partial class Form1 : Form {
        private List<Versenyzo> versenyzok = new List<Versenyzo>();


        public Form1()
        {
            InitializeComponent();
        }

        private void fileMenuMegnyit_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            using (StreamReader sr = new StreamReader(dialog.FileName))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    versenyzok.Add(new Versenyzo(line[0], line[1]));
                }
            }
        }

        private void fileMenuKilepes_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}