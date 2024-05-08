using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Vivejdane na danni:");
            int n = int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            int[] nomer = new int[n];
            string[] predmet = new string[n];
            double[] ocenka = new double[n];
            //vhod-(2,25)
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ime:");
                ime[i] = Console.ReadLine();
                Console.WriteLine("Nomer v klas:");
                nomer[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Predmet:");
                predmet[i] = Console.ReadLine();
                Console.WriteLine("Ocenka:");
                ocenka[i] = double.Parse(Console.ReadLine());
                Console.Write("Az ", ime[i], "s nomer v klas ", nomer[i], "po predmet ", predmet[i], "imam ", ocenka[i]);
            }
            //Izhod 1-(2,50)
            for (int i = 0; i < n; i++)
            {
                if (ocenka[i] >= 5.25)
                {
                    Console.WriteLine("Otlicna ocenka");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            //Izhod 2-(3,00)
            for (int i = 0; i < ocenka.Length - 1; i++)
            {
                for (int j = 0; j < ocenka.Length - 1; j++)
                {
                    if (ocenka[j] < ocenka[j + 1])
                    {
                        double swapDouble = ocenka[j];
                        ocenka[j] = ocenka[j + 1];
                        ocenka[j + 1] = swapDouble;
                    }
                }
            }
            for (int i = 0; i < ocenka.Length; i++)
            {
                Console.Write(ocenka[i] + " ");
            }
            //Izhod 3-(4,00)
            for (int i = 0; i < n; i++)
            {
                if (ime[i] == "Genadi")
                {

                    if (ocenka[i] + nomer[i] >= 5 / 10)
                    {
                        Console.Write("Ima ", ocenka[i], "i nomera mu e", nomer[i]);
                    }
                   
                    if (nomer[i] < 5 / 10)
                    {
                        Console.Write("Ima,", ime[i], "no e s nomer ", nomer[i]);
                    }
                    
                    if (ime[i] != "Genadi")
                    {
                        Console.WriteLine("Nqma takiv!");
                    }
                }
            }
            //Izhod 4-(5,00)
            for (int i = 0; i < n; i++)
            {
                if (ime[i] == ime[i])
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        for (int k = i; k < n - 1 - i; k++)
                        {
                            if (nomer[k] < nomer[k + 1])
                            {
                                        int swapInt = nomer[k];
                                nomer[k] = nomer[k + 1];
                                nomer[k + 1] = swapInt;
                            }
                        }
                    }
                    for (int j = 0; j < n - 1; j++)
                    {
                        Console.Write(nomer[j] + " ");
                    }
                }
            }
            //Izhod 5-(6,00)
            //for (int i = 0; i < n; i++)
            //{
            //    if (predmet[i] == "")
            //    {
            //        string.Compare(ime[i], predmet[i]);
            //    }
            //}
        }
    }
}
