using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    //komentar
    class Datum {
        private int dan, mesec, leto;

        public Datum(int dan,int mesec, int leto) {
            this.dan = dan;
            this.mesec = mesec;
            this.leto = leto;
        }
        public Datum(){
            this.dan = 1;
            this.mesec = 1;
            this.leto = 2000;
        }
        public Datum(Datum d) {
            this.dan = d.dan;
            this.mesec = d.mesec;
            this.leto = d.leto;
        }
        public void VpisiDatum(int dan,int mesec, int leto) {
            this.dan = dan;
            this.mesec = mesec;
            this.leto = leto;
        }
        public string IzpisiDatum() {
             string izpis = dan+"."+mesec+"."+leto;
             return izpis;
        }
        
    }
    class Oseba {
        protected string ime, priimek;
        protected string spol;
        protected enum Spol {moski,zenska }
        protected Datum datum_r;

        public Oseba()
        {
            this.ime = "Janez";
            this.priimek = "Novak";
            this.spol = "moski";
            Datum datum_r = new Datum();
            
        }
        public Oseba(string ime,string priimek,string spol,Datum datum_r) {
            this.ime = ime;
            this.priimek = priimek;
            this.spol = spol;
            this.datum_r = datum_r;

        }
        public Oseba(Oseba oseba)
        {
            this.ime = oseba.ime;
            this.priimek = oseba.priimek;
            this.spol = oseba.spol;
            this.datum_r = oseba.datum_r;

        }
        public void VpisiOsebo(string ime, string priimek, string spol,int dan,int mesec,int leto)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.spol = spol;
            Datum datum_r = new Datum(dan, mesec, leto);
        }
        public string IzpisiOsebo()
        {
            string izpis = "Podatki: \n" + ime + "\n" + priimek + "\n" + spol + "\n" + datum_r.IzpisiDatum() + "\n";
            return izpis;
        }
        public void SePoroci(Oseba zenin, Oseba nevesta) {
            nevesta.priimek = zenin.priimek;
        }
    }
    class Student : Oseba {
        private string smer;
        public Student()
        {

            this.smer = "Neznana smer";

        }
        public Student(string ime, string priimek, string spol, Datum datum_r, string smer)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.spol = spol;
            this.datum_r = datum_r;
            this.smer = smer;

        }
        public Student(Student s)
        {
            this.smer = s.smer;

        }

        public void VpisiStudenta(string ime, string priimek, string spol, Datum datum_r,string smer)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.spol = spol;
            this.datum_r = datum_r;
            this.smer = smer;
        }
        static public string IzpisiStudenta(Student s) {
            string izpis = "Podatki: \n" + s.ime + "\n" + s.priimek + "\n" + s.spol + "\n" + s.smer + "\n" + s.datum_r.IzpisiDatum() + "\n";
            return izpis;
        }
    }
    class Program
    {
        static void Main(string[] args)
            
        {
            Datum d1 = new Datum(29, 1, 1998);
            Oseba o = new Oseba("blaz","zdolsek","moski",d1);
            Console.Write(o.IzpisiOsebo());
            Student s1 = new Student("blaz", "zdolsek", "moski", d1,"racunalniska");
            Console.WriteLine(Student.IzpisiStudenta(s1));
            
        }
    }
}
