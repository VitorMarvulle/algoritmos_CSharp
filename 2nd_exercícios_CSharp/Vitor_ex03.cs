namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio

            String? nome, nome1, nome2, nome_pa, nome_tro; // "!" indica que a variável não será nula e evite msg de erro/aviso
            int pos;

        Console.Write("Digite seu nome completo: ");
        nome = Console.ReadLine();
        pos = nome!.IndexOf(" "); // "!" indica que a variável não será nula e evite msg de erro/aviso
        nome1 = nome.Substring(0, pos); //inicia do caractere 0 e vai até a variável pos (espaço " ")
        nome2 = nome.Substring(pos +1); //inicia o "corte" a partir da variável pos (espaço) +1 caractere (início do sobrenome)
        nome_pa = nome.Substring(5, 10);
        nome_tro = nome.Replace("a", "o");
        Console.WriteLine("Nome digitado             : " + nome);
        Console.WriteLine("Seu primeiro nome é       : " + nome1);
        Console.WriteLine("Seu sobrenome é           : " + nome2);
        Console.WriteLine("Caractere 5 à 10:         : " + nome_pa);
        Console.WriteLine("Caracteres 'a' por 'o'    : " + nome_tro);
        Console.ReadKey();
        }//fim
    }
}