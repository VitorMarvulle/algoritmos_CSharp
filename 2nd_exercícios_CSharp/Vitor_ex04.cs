namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio

            String? nome, nome1; // "?" permite que a variável seja nula e evite msg de erro/aviso
            int pos;

        Console.Write("Digite seu nome completo: ");
        nome = Console.ReadLine();
        pos = nome!.IndexOf(" "); // "!" permite que a variável seja nula e evite msg de erro/aviso
        nome1 = nome.Substring(0, pos); //inicia do caractere 0 e vai até a variável pos (espaço " ")

        Console.WriteLine("Seu email é      : " + nome1.ToLower() + "@fatec.sp.gov.br");
        Console.ReadKey();
        }//fim
    }
}