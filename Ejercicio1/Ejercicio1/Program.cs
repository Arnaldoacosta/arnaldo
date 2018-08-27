using System;

namespace Ejercicio1
{
    class Program
    {

        static void Main(string[] args)

        {


            int[] vec = new int[6];
            int x, y;

            for (int i = 0, j = 0; i < 3; i++, j = j + 2)
            {
                Console.WriteLine("Ingrese cordenada:\n");

                Console.WriteLine("Ingrese valor de x:\n");
                vec[j] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese valor de y:\n");
                vec[j + 1] = int.Parse(Console.ReadLine());
            }

            double d1 = Math.Pow((vec[1] - vec[0]), 2) + Math.Pow((vec[3] - vec[2]), 2);
            double dis1 = Math.Sqrt(d1);
      
            double d2 = Math.Pow((vec[1] - vec[0]), 2) + Math.Pow((vec[5] - vec[4]), 2);
            double dis2 = Math.Sqrt(d2);
      
            double d3 = Math.Pow((vec[5] - vec[4]), 2) + Math.Pow((vec[3] - vec[2]), 2);
            double dis3 = Math.Sqrt(d3);

            double prom = (dis1 + dis2 + dis3) / 3;

            Console.WriteLine("La distancia promedio es:"+prom);
            Console.ReadKey();

        
            
        }
       
            
    }

