using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA230320
{
    internal class Versenyzo
    {
        public string Nev { get; set; }
        public int RajtSzam { get; set; }
        public string Kategoria { get; set; }
        public string Idoeredmeny { get; set; }
        public int TavSzazalek { get; set; }

        public Versenyzo(string fileEgySora)
        {
            string[] aFileSoranakDarabjai = fileEgySora.Split(';');
            this.Nev = aFileSoranakDarabjai[0];
            this.RajtSzam = int.Parse(aFileSoranakDarabjai[1]);
            this.Kategoria = aFileSoranakDarabjai[2];
            this.Idoeredmeny = aFileSoranakDarabjai[3];
            this.TavSzazalek = int.Parse(aFileSoranakDarabjai[4]);
        }
    }
}
