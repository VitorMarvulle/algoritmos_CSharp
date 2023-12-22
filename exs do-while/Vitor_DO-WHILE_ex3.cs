        {//inicio
            int num;

            do
            {
            
            Console.WriteLine("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());
                while (num > 1)
                {
                    Console.WriteLine("Número INCORRETO, tente novamente: ");
                    num = Convert.ToInt32(Console.ReadLine());

                }
                    
            } while(num > 1);
            Console.WriteLine("Número encontrado!");
            Console.ReadKey();

        }//fim
