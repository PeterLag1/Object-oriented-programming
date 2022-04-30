using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.WriteLine("\tSELECCIONE EL METODO\n1 -> Array\n2 -> List\n3 -> Salir");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        int num;
                        Console.WriteLine("Cunatos estudiantes desea ingrear: ");
                        num = int.Parse(Console.ReadLine());
                        int[] Studenst = new int[num];
                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine($"Ingrese la nota del estudiante {i + 1}: ");
                            Studenst[i] = int.Parse(Console.ReadLine());
                            if (Studenst[i] < 60)
                            {
                                Console.WriteLine("Reprobado");
                            }
                            else
                            {
                                Console.WriteLine("Aprobado");
                            }
                        }
                        break;

                    case 2:
                        List<int> StuLis = new List<int>();
            
                        Console.WriteLine("Ingrese el numero de estudiantes");
                        int n = int.Parse(Console.ReadLine());
                     
                        for (int i = 0; i < n; i++)
                        {
                           Console.WriteLine($"Ingrese la onta del estudiante {i + 1}");
                           StuLis.Add(int.Parse(Console.ReadLine()));
                            if (StuLis[i] < 60)
                            {
                                Console.WriteLine("Reprobado");
                            }
                            else
                            {
                                Console.WriteLine("Aprobado");
                            }
                        }
                        

                        break;

                    default:
                        Console.WriteLine("ERROR: Valor no valido");
                        break;
                }
            } while (menu != 3);
        }
    }
}