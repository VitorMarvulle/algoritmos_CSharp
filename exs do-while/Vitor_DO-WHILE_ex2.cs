        {//inicio

            bool continua = true;
            double nota, soma=0, media;
            int c = 1;
            do
            {
                while (c <= 4)
                {

                    do
                    {
                        Console.WriteLine("Entre com a " + c + "ª nota: ");
                        nota = Convert.ToDouble(Console.ReadLine());

                    } while (nota < 0 || nota > 10);
                    soma = nota + soma;
                    c++;

                }

                c--;
                media = soma / c;

                Console.WriteLine("Total de pontos da turma: " + soma);
                Console.WriteLine("Média da turma: " + media);


                Console.WriteLine("Deseja continuar? S ou N :");
                string resp = Console.ReadLine();

                if (resp.ToUpper() == "N")
                {
                    continua = false;
                }
                else if (resp.ToUpper() == "S")
                {
                    c = c - 3;
                    soma=0;
                    Console.WriteLine("Continuando programa . . . ");
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, digite S para continuar ou N para encerrar.");
                    resp = Console.ReadLine();
                }

            } while (continua);

            Console.WriteLine("Programa encerrado.");
            Console.ReadKey();
        }//fim