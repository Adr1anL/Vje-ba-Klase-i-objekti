using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Zrakoplov
    {
        string Naziv;
        double SnagaMotora;
        int DosegLeta;

        public string Naziv1 { get => Naziv; set => Naziv = value; }
        public double SnagaMotora1 { get => SnagaMotora; set => SnagaMotora = value; }
        public int DosegLeta1 { get => DosegLeta; set => DosegLeta = value; }

        public Zrakoplov(string Naziv, double SnagaMotora, int DosegLeta)
        {
            this.Naziv1 = Naziv;
            this.SnagaMotora1 = SnagaMotora;
            this.DosegLeta1 = DosegLeta;
        }
        public override string ToString()
        {
            string ispis =
                "Naziv: " + this.Naziv1 + "\n" +
                "Snaga Motora: " + this.SnagaMotora1 + " kW\n" +
                "Doseg Leta: " + this.DosegLeta1 + " km\n";
            return ispis;
        }

        Zrakoplov() { }
    }
}
