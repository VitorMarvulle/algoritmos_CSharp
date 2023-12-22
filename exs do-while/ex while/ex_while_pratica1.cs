        {//inicio
            int i, f;

            Console.WriteLine("Digite o número inicial:");
            i=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número final:");
            f = Convert.ToInt32(Console.ReadLine());
            if (f<i)
            {
                Console.WriteLine("Número final maior que o inicial, insira outro: ");
                f=Convert.ToInt32(Console.ReadLine());
            }
            while (f > i)
            {
                i = i + 1; Console.WriteLine(i);
            }

            Console.ReadKey();

        }//fim