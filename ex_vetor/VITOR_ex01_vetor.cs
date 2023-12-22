        {//inicio

            string[] nome = new string[5];
            double[] n1 = new double[5];
            double[] n2 = new double[5];


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite seu Nome: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Digite sua primeira Nota: ");
                n1[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite sua segunda Nota: ");
                n2[i] = Convert.ToDouble(Console.ReadLine());
               
            }

            for (int i=0; i<5; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluno: " + nome[i]);
                Console.WriteLine("Nota1: " + n1[i]);
                Console.WriteLine("Nota2: " + n2[i]);
                Console.WriteLine("Média: " + (n1[i] + n2[i]) / 2);
                Console.WriteLine("--------------------");
            }            
            Console.ReadKey();

        }//fim