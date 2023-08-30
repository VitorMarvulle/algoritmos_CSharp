using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {//inicio do script
            string? nome1, nome2; //o "?" na declaração string é para setar a variável como anulável
            Console.Write("Entrar com o seu Primeiro Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Entrar com seu Sobrenome: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Seu nome Completo é: " + nome1 + " " + nome2);
        }

    }

}
