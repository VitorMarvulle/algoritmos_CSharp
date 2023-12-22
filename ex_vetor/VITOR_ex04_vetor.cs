        {//inicio

            int[] Q = new int[20];
            int pos = 0, maior=0;
            
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite o " + i + "º número: ");
                Q[i] = Convert.ToInt32(Console.ReadLine());

                if (Q[i] < 0)
                {
                    Console.WriteLine("VALOR INVÁLIDO! Digite um número MAIOR que zero: ");
                    Q[i] = Convert.ToInt32(Console.ReadLine());
                }           
            }
            Console.WriteLine("Maior número digitado: " + Q.Max() + " na posição: " + Array.IndexOf(Q, Q.Max()));
            Console.ReadKey();
        }//fim