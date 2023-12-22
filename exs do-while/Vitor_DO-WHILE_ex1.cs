        {//inicio

            int num=0;
                do
                {
                    
                    Console.WriteLine("Digite um número par: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Seu número é:  " + num);

                }
                while(num % 2 ==0);

            Console.WriteLine("O número NÃO é par!");
            Console.ReadKey();
        }//fim