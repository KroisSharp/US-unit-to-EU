using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace us_eu_unet
{
    class weightUS
    {
        // 1 spoon = 15 gram
        public Double TablespoonUS { get; set; }
        // 1 tea = 4,9ML
        public Double TeaspoonUS { get; set; }
        //29ML eller 28Gram
        public Double OunceUS { get; set; }
        //0.453Gram
        public Double PoundUS { get; set; }
        // cup = 2,36 DL
        public Double CupUS { get; set; }

        public string value { get; set; }
        public Double svar { get; set; }

        //metoder regne, printe
        public Double TablespoonRegne()
        {
            return TablespoonUS * 15; 
        }

        public Double TeaspoonRegne()
        {
            return TeaspoonUS * 4.92892159;
        }

        public double OunceRegneGram()
        {
            return OunceUS * 28.3495231;
        }

        public double OunceRegneML()
        {
            return OunceUS * 29.5735296;
        }
        public double PoundRegne()
        {
            return PoundUS * 0.45359237;
        }
        public double CupRegne()
        {
            return CupUS * 2.36588;
        }
        public void HvadErValgt()
        {
            if (value == "a")
            {
                svar = TablespoonRegne();
            }
            else if (value == "b")
            {
                svar = TeaspoonRegne();
            }
            else if (value == "c")
            {
                svar = OunceRegneGram();
                PrintGram();
                svar = OunceRegneML();
                PrintML();
            }
            else if (value == "d")
            {
                svar = PoundRegne();
            }
            else if (value == "e")
            {
                svar = CupRegne();
            }
        }

        public void PrintGram()
        {
            Console.WriteLine(svar + " gram");
        }
        public void PrintML()
        {
            Console.WriteLine(svar + " ML");
        }
        public void PrintKG()
        {
            Console.WriteLine(svar + " KG");
        }
        public void PrintEnhed(string enhed)
        {
            Console.WriteLine(svar + enhed);
        }
        /// <summary>
        /// du kan endda lave en print der hedder: 
        /// public void PrintKG(string Enhed)
        /// console.writeline(svar + enhed)
        /// </summary>


        //måske virker det her faktisk PogChamp
        public void makenew(string navn, string enhed)
        {
            Console.WriteLine("du valgte {0} til {1}", navn, enhed);
            Console.WriteLine("tryk \"t\" for at komme tilbage");
            Console.WriteLine("skriv antal {0}s", navn);
        }
    }
}
