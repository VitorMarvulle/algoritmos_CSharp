using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano_atual, ano_nasc, idade;
            Console.Write("Digite o ano atual: ");
            ano_atual = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o ano de nascimento: ");
            ano_nasc = Convert.ToInt16(Console.ReadLine());
            
            idade = ano_atual - ano_nasc;

            Console.WriteLine("Sua idade é " +idade+ " anos");
            
        }
    }
}