using System;

namespace JobbUszoverseny {
    public class Versenyzo {
        private static int VersenyzokSzama;

        private string nev;
        private string orszag;
        private TimeSpan ido = TimeSpan.Zero;
        private int rajtszam;

        public string Nev => nev;
        public string Orszag => orszag;
        public int Rajtszam => rajtszam;

        public TimeSpan Ido
        {
            get => ido;
            set => ido = value;
        }

        public Versenyzo(string nev, string orszag)
        {
            VersenyzokSzama++;

            this.nev = nev;
            this.orszag = orszag;
            this.rajtszam = VersenyzokSzama;
        }
    }
}