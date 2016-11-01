using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace us_eu_unet
{
    class Program
    {
        static void Main(string[] args)
        {
            weightUS vejer1 = new weightUS();

            bool sandt = true;
            while (sandt)
            {
                Console.Clear();
                Console.WriteLine("hvad vil du gerne vælge");
                Console.WriteLine("");
                Console.WriteLine("A: Tablespoon til gram \n\nB:Teaspoon til ML \n\nC:Ounce til ML eller Gram \n\nD: Pound til Gram/KG \n\nE: Cup til DL");
                string valg = Console.ReadLine();

                #region Tablespoon "a"
                if (valg == "a")
                {
                    while (sandt)
                    {
                        vejer1.value = "a";
                        Console.Clear();
                        Console.WriteLine("du valgte Tablespoon til gram");
                        Console.WriteLine("tryk \"t\" for at komme tilbage");
                        Console.WriteLine("skriv antal tablespoon(s)");
                        string Tal1 = Console.ReadLine();

                        if (Tal1 == "t")
                        {
                            break;
                        }

                        double Tablespooninput = Double.Parse(Tal1);
                        vejer1.TablespoonUS = Tablespooninput;
                        vejer1.HvadErValgt();
                        vejer1.PrintGram();
                        Console.WriteLine("\nTryk Enter for at forsætte");
                        Console.ReadLine();


                    }
                     
                    
                }
                #endregion
                #region Teaspoon "b"
                else if (valg == "b")
                {
                    while (sandt)
                    {
                        vejer1.value = "b";
                        Console.Clear();
                        Console.WriteLine("du valgte teaspoon til ML");
                        Console.WriteLine("tryk \"t\" for at komme tilbage");
                        Console.WriteLine("skriv antal teaspoon(s)");
                        string Tal1 = Console.ReadLine();

                        if (Tal1 == "t")
                        {
                            break;
                        }

                        Double Teaspooninput = Double.Parse(Tal1);
                        vejer1.TeaspoonUS = Teaspooninput;
                        vejer1.HvadErValgt();
                        vejer1.PrintML();
                        Console.WriteLine("\nTryk Enter for at forsætte");
                        Console.ReadLine();
                    }
                }
                #endregion
                #region ounce "c"
                if (valg == "c")
                {
                    while (sandt)
                    {
                        vejer1.value = "c";
                        Console.Clear();
                        Console.WriteLine("du valgte Ounce til gram/ML");
                        Console.WriteLine("tryk \"t\" for at komme tilbage");
                        Console.WriteLine("skriv antal Ounces(s)");
                        string Tal1 = Console.ReadLine();

                        if (Tal1 == "t")
                        {
                            break;
                        }

                        double Ounceinput = double.Parse(Tal1);
                        vejer1.OunceUS = Ounceinput;
                        vejer1.HvadErValgt();
                        Console.WriteLine("\nTryk Enter for at forsætte");
                        Console.ReadLine();


                    }


                }


                #endregion
                #region Pound "d"
                if (valg == "d")
                {
                    while (sandt)
                    {
                        vejer1.value = "d";
                        Console.Clear();
                        Console.WriteLine("du valgte Pound til KG");
                        Console.WriteLine("tryk \"t\" for at komme tilbage");
                        Console.WriteLine("skriv antal Pound(s)");
                        string Tal1 = Console.ReadLine();

                        if (Tal1 == "t")
                        {
                            break;
                        }

                        double Poundinput = double.Parse(Tal1);
                        vejer1.PoundUS = Poundinput;
                        vejer1.HvadErValgt();
                        vejer1.PrintKG();
                        Console.WriteLine("\nTryk Enter for at forsætte");
                        Console.ReadLine();


                    }


                }


                #endregion
                #region Cup "e"
                if (valg == "e")
                {
                    while (sandt)
                    {
                        vejer1.value = "e";
                        Console.Clear();
                        // lavet ny metoede for at teste om det virkede og ja.
                        vejer1.makenew("cup", "DL");
                        string Tal1 = Console.ReadLine();

                        if (Tal1 == "t")
                        {
                            break;
                        }

                        //faktisk kunne enhederne være helt det samme det er kun "vejer1.NAVN" der faktisk skulle ændres!
                        double cupinput = double.Parse(Tal1);
                        vejer1.CupUS = cupinput;
                        vejer1.HvadErValgt();
                        vejer1.PrintEnhed("DL");
                        Console.WriteLine("\nTryk Enter for at forsætte");
                        Console.ReadLine();

                    }


                } 
                #endregion
            }
            Console.ReadLine();
        }
    }
}
