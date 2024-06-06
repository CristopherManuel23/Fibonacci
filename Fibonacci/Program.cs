using System;

namespace suma_del_numero_anterior
{
    class progran
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Fibonacci\n");

            Console.WriteLine("Ingrese el numero para iniciar el patron Fibonacci:");
            int Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Patron Fibonacci:");
            for (int i = 0; i < Numero; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

}
