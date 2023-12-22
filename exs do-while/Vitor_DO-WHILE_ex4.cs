        {//inicio
            int num, soma=0;

            do
            {
            
            Console.WriteLine("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());
                while (num > 0)
                {
                    Console.WriteLine("Número INCORRETO, tente novamente: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    soma = num + soma;
                }
                    
            } while(num > 0);
            Console.WriteLine("Número encontrado! O loop acabou!");
            Console.WriteLine("A soma de todos os números digitados foi: " + soma);
            Console.ReadKey();

        }//fim