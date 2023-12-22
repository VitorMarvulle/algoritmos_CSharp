using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio

            int n, num;
            int soma = 0;
            Console.Write("digite n: ");
            n=Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite o número para somar: ");
                num = Convert.ToInt32(Console.ReadLine());
                soma = num+ soma;
            }
            Console.WriteLine(soma);
            Console.WriteLine("A meédia é: " + soma / n);



            Console.ReadKey();
        }//fim

    }
}

