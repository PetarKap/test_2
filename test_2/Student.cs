using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
    public class Student
    {

        public  string Ime { get; set; }
            public  string Prezime { get; set; }
            public  DateTime Datum_Rodenja { get; set; }
            public  string Razred { get; set; }
            public  int Broj_izostanaka { get; set; }
            public int Opravdano { get; set; }
    }
}
