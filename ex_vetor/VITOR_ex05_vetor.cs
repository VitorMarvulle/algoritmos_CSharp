        {//inicio
            int[] VET = new int[15];
            

            for (int i = 0; i < VET.Length; i++)
            {
                Console.WriteLine("Digite o "+i+"º valor: ");
                VET[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("ORDEM CRESCENTE");
            Array.Sort(VET);
            foreach (int numeros in VET)
            {
                Console.WriteLine(numeros);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("ORDEM DECRESCENTE");
            Array.Reverse(VET);

            foreach (int numeros in VET)
            {
                Console.WriteLine(numeros);
            }

            Console.ReadKey();

        }//fim