namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        int n0, n1, n2, n3, res;

            do
            {
                Console.WriteLine("Calculadora\n1 -> Suma\n2 -> Resta\n3 -> Multiplicacion\n4 -> Divicion");
            n0 = int.Parse(Console.ReadLine());
                switch (n0)
                {
                    case 1:
                        Console.WriteLine("\tSUMA\nIngrese los 3 datos");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        n3 = int.Parse(Console.ReadLine());
                        res = n1 + n2 + n3;
                        Console.WriteLine($"El resultado es: {res}");
                        break;

                    case 2:
                        Console.WriteLine("\tRESTA\nIngrese los 3 datos");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        n3 = int.Parse(Console.ReadLine());
                        res = n1 - n2 - n3;
                        Console.WriteLine($"El resultado es: {res}");
                        break;

                    case 3:
                        Console.WriteLine("\tMULTIPLICACION\nIngrese los 3 datos");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        n3 = int.Parse(Console.ReadLine());
                        res = n1 * n2 * n3;
                        Console.WriteLine($"El resultado es: {res}");
                        break;

                    case 4:
                        Console.WriteLine("\tDIVICION\nIngrese los 3 datos");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = Console.Read();
                        n3 = Console.Read();
                        res = n1 / n2 / n3;
                        Console.WriteLine($"El resultado es: {res}");
                        break;

                    default:
                        Console.WriteLine("ERROR: Valor no valido");
                        break;
                }

                Console.WriteLine("Desea salir?\n1 -> No\n5 -> Si");
                n0 = int.Parse(Console.ReadLine());

            } while (n0 != 5);
        }
    }
}