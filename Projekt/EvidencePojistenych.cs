using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class EvidencePojistenych
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int TelefonniCislo { get; set; }
        public int Vek { get; set; }

        public EvidencePojistenych(string jmeno, string prijmeni, int telefonniCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelefonniCislo = telefonniCislo;
            Vek = vek;
        }
        public override string ToString()
        {
            return Jmeno + "\t" + Prijmeni + "\t" + Vek + "\t" + TelefonniCislo;
        }
    }
}
