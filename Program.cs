using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            zad1();
            Console.ReadLine();
        }

        static int[,] tab1= new int[100,2];
        static int[] tab2 = new int[100];

        public static void zad1() {
            Console.WriteLine("Zad 1");
            zapelnijTablice1();
            zapelnijTablice2();
            wyswitltablice1();
            wyswitltablice2();
            List<Action> lista = new List<Action>();
            lista.Add(posumujTab1);
            lista.Add(posumujJednocyfroweTab1);
            Parallel.Invoke(lista.ToArray());
        }
        static void zapelnijTablice1() {
            Random r = new Random();
            for (int i = 0; i< 100; i++) {
                
                tab1[i, 0] = r.Next(0,50);
                tab1[i, 1] = r.Next(0,50);
            }
        }
        static void zapelnijTablice2()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                
                tab2[i] = r.Next(0, 50);
            }
        }
        static void wyswitltablice1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(tab1[i, 0]);
                Console.Write(" ");
                Console.Write(tab1[i, 1]);
                Console.WriteLine();
            }
        }
        static void wyswitltablice2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(tab2[i]);
                Console.WriteLine();
            }
        }
        static void posumujTab1() {
            int[] suma = new int[2];
            suma[0] = 0;
            suma[1]=1;
            for (int i = 0; i < 100; i++)
            {
                suma[0]=suma[0]+tab1[i, 0];
                suma[1] = suma[1] + tab1[i, 1];
            }
            Console.WriteLine("Suma dla pierwszego wiersza :" + suma[0]);
            Console.WriteLine("Suma dla drugiego wiersza :" + suma[1]);
        }
        static void posumujJednocyfroweTab1() {
            int suma = 0;
            
            for (int i = 0; i < 100; i++)
            {
                if (tab1[i, 0] < 10) {
                    suma = suma + tab1[i, 0];
                }
                if (tab1[i, 1] < 10)
                {
                    suma = suma + tab1[i, 1];
                }
            }
            Console.WriteLine("Suma :" + suma);
        }

    }
}