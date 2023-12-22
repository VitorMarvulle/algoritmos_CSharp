        {//inicio

            int n, i=1, neg=0;
            
            while(i<=10)
            {
                Console.WriteLine("Digite o " + i + "º número: ");
                n=Convert.ToInt32(Console.ReadLine());
                i++;

                if (n < 0)
                {
                    neg = neg+1;
                }
            }
            Console.WriteLine("A quantidade de números negativos é: " + neg);
            Console.ReadKey();

        }//fim