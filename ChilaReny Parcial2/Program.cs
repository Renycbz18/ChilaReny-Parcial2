﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilaReny_Parcial2
{
    class Program
    {
        LeerVecto(x);
        mayorymeno(x);
        Ordenar(x);
        ImprimirVecto(x);
        Console.ReadKey();
    }



    const int MAX = 10;
    static void Main(string[] args)
        
        public static void vectorinicial()
    {

        int[] x = new int[8];
        x[0] = 10;
        x[1] = 10;
        x[2] = 10;
        x[3] = 10;
        x[4] = 10;
        x[5] = 10;
        x[6] = 10;
        x[7] = 10;
        x[8] = 10;
        x[9] = 10;
        x[10] = 10;
        Console.WriteLine("\nElEmentos del vector\n=====================");
        for (int i = 0; i < 8; i++)
        {

            Console.WriteLine("elemento indice {0} --> {1}", (i + 1), x[i]);

        }

        //Random
        {
            int[] x = new int[MAX];
            LeerVector(x);
            Console.WriteLine("\n ELEMENTOS DEL VECTOR");
        }

        public static void LeerVector(int[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                var randomNumber = new Random().Next(1, 5000);
                x[i] = randomNumber;
            }
        }

        public static void ImprimirVector(int[] x)
        {
            for (int i = 0; i < MAX; i++)
                Console.WriteLine("ELEMENTO {0}= {1}",);
        }




        //Sacar maximo y minimo
        public static void mayorymenor()

        {

            int[] vec = new int[10];

            int mayor = vec[0], menor = vec[0];


            for (int i = 0; i < vec.Length; i++)

            {

                while (vec[i] < 1 || vec[i] > 1000)

                {
                    Console.WriteLine("Ingrese valor {0} del vector", i + 1);
                    vec[i] = Int32.Parse(Console.ReadLine());
                }


            }

            for (int i = 0; i < vec.Length; i++)

            {

                if (vec[i] > mayor)
                {

                    mayor = vec[i];

                }

            }

            menor = mayor;

            for (int i = 0; i < vec.Length; i++)

            {

                if (vec[i] < menor)

                {

                    menor = vec[i];

                }

            }



            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);
        }
        //Menor a Mayor
        public static void Ordenar(string[] x)
        {
            string aux = "";
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i; j < x.Length; j++)
                {
                    if (String.Compare(x[i], x[j], StringComparison.Ordinal) > 0)
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
                }
            }
        }
    //EJERCICIO 2

    }
}
