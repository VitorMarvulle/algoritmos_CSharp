        {//inicio

            string[] nomes = new string[10];
            string nome2;

            for (int i = 0; i < nomes.Length; i++)

            {
                Console.WriteLine("Digite o " + i + "º nome: ");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine("Digite o último nome: ");
            nome2 = Console.ReadLine();

            for (int i = 0; i<nomes.Length; i++)
            if (nome2 == nomes[i])
            {
                    Console.WriteLine(" ACHEI! O nome " + nomes[i] +" da posição "+i+" é igual ao nome:" + nome2);
            }

                else
                {
                    Console.WriteLine("NÃO ACHEI");
                }

            Console.ReadKey();  

        }//fim