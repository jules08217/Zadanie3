using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№1");
            int[] m = new int[] { -11, 3, -7, 22, -4, 2, 6, -5 };
            int min = 100;
            int n = 0;
            for(int i = 0; i < 8; i++)
            {
                if(Math.Abs(m[i]) < min)
                {
                    min = Math.Abs(m[i]);
                    n = i;
                }
            }
            Console.WriteLine("Номер элемента: " + n);

            Console.WriteLine("№2");
            int[] m2 = new int[] { 2, 4, -7, 0, 4, -7, 1, 5, 22, 1 };
            int s = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.Write(m2[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                s = 1;
                for(int j = 0; j < 10; j++)
                {
                    
                    if(m2[i] == m2[j] && i != j)
                    {
                        s = 2;
                    }
                }
                if(s == 1)
                {
                    Console.Write(m2[i] + " ");
                }
            }

            Console.WriteLine("\n№3");
            int[] m3 = new int[10];
            Random r = new Random();
            for(int i = 0; i < 10; i++)
            {
                m3[i] = r.Next(-50, 50);
                Console.Write(m3[i] + " ");
            }
            Console.WriteLine();
            for(int j = 0; j < 10; j++)
            {
                if(m3[j] > 0)
                {
                    Console.Write(m3[j] + " ");
                }
            }



        }
    }
}
