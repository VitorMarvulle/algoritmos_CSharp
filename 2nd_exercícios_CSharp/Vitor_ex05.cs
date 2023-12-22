namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio

            String? nome, nome1, nome2; // "?" permite que a variável seja nula e evite msg de erro/aviso
            int pos1, pos2;

        Console.Write("Digite seu nome completo: ");
        nome = Console.ReadLine();
        pos1 = nome!.IndexOf(" "); // seta o primeiro espaço " " como Index. "!" permite que a variável seja nula e evite msg de erro/aviso
        pos2 = nome!.LastIndexOf(" "); // seta o último espaço " " como LastIndex. "!" permite que a variável seja nula e evite msg de erro/aviso
        nome1 = nome.Substring(0, pos1); //inicia do caractere 0 e vai até a variável pos (espaço " ")
        nome2 = nome.Substring(pos2 +1); //inicia do LastIndex (último espaço mais um caractere [remove o próprio espaço]) e vai até o final da string.

        Console.WriteLine("Seu email é         : " + nome1.ToLower() + "." + nome2.ToLower() + "@fatec.sp.gov.br"); //converte para caracteres minúsculos direto no WriteLine
        Console.ReadKey();
        }//fim
    }
}