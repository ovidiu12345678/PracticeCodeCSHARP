using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodeCSHARP
{
    public class Students
    {

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string specializare { get; set; }

        public Students(string nume, string prenume, string specializare)
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.specializare = specializare;   
        }

        
  

    }
}
