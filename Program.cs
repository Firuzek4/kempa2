﻿using System;
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
            Console.WriteLine();
            Console.WriteLine(zad3());
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

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
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

        static int[,] sprzedarz = new int[5, 12];

        static void zad2() {
            Console.WriteLine("Zad 2");
            uzupelnijSprzedaz();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        static void uzupelnijSprzedaz() {
            Random r = new Random();
            for (int i = 0; i < 5; i++) {
                for (int y = 0; y < 12; y++) {
                    sprzedarz[i, y] = r.Next(0, 100);
                    Console.Write(sprzedarz[i, y]);
                }
                Console.WriteLine();
            }
        }

        static string zad3() {
            Console.WriteLine("Podaj lancuch znakowy do zadania 3");
            string parametrWejsciowy=Console.ReadLine();
            var task1 = podajLiczbeZnakow(parametrWejsciowy);
            var task2 = podajSumePrzedzialu();
            
            return "Suma znakow : "+task1.GetAwaiter().GetResult().ToString()+"     "+task2.GetAwaiter().GetResult(); 

        }
        

        static async Task<int> podajLiczbeZnakow(Object o) {
            string parametr = (String)o;
            return parametr.Length;
        }
        static async Task<int> podajSumePrzedzialu() {
            int suma = 0;
            for (int i = 100; i < 1000; i++) {
                String x = i.ToString();
                if (x[0] == x[2])
                    suma = suma + i;
            }
            return suma;
        }
    }
}