using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            Console.WriteLine("digite o primeiro numero");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("seus numeros são: {0}, {1} ",x,y);
        }
    }
}

