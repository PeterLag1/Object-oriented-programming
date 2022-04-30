using System;

namespace Microondas 
{
    public class program
    {
        static void Main()
        {
            //Declaracion de las dimenciones
            
            int dim1, dim2;
            Console.Write("La dimencion del array sera de: ");
            dim1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write($"La dimencion del array sera de: {dim1} X ");
            dim2 = int.Parse(Console.ReadLine());


            //Almacenamiento de datos
            
            int[,] a = new int[dim1, dim2];
            int vertice1 = 0, vertice2 = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor de [{i},{j}]");
                    a[i, j] = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }

            //Suma de lineas
            int cache = 0;
            int[] buffer = new int [dim1];
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    cache = cache + a[i, j];
                }
                buffer[i] = cache;
                cache = 0;
            }
                

            //Vertices 
            int n = 0, p = 0, x = dim1, y = dim2;
            do
            {
                vertice1 = a[n, p] + vertice1;
                vertice2 = a[n, p] + vertice2;
                n++;
                p++;
                x++;
                y++;
            } while (n != dim1);

            //Impresion de respuestas
            Console.Clear();
            for (int i = 0; i < dim1; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < dim2; j++)
                {
                    Console.Write($"{a[i,j]} ");
                    if (dim2 != j +1)
                    {
                        Console.Write(" | ");
                    }
                }
                if(i == 0)
                {
                    Console.Write($"] = {buffer[i]}\n");
                }
                else 
                {
                    if (i != dim1 - 1)
                    {
                        Console.Write($"| = {buffer[i]}\n");
                    }
                    else
                    {
                        Console.Write($"] = {buffer[i]}\n");
                    }
                }
            }
            
            Console.WriteLine($"Suma de los vertices desde punto A a punto B es: {vertice1}");
            Console.WriteLine($"Suma de los vertices desde punto B a punto A es: {vertice2}");
        }
        
    }
}