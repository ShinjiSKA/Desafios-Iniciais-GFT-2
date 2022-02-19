using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
              
                
                 //escreva aqui o seu código
                inicio = i * i;
                int n3 = i * inicio;
                Console.WriteLine($"{i} {inicio} {n3}");
            }
        }
    }
}
