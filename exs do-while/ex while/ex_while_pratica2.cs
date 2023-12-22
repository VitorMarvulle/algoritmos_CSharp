        {//inicio

            int id, p=1, m_id=0;

            while (p < 10)
            {
                Console.WriteLine("Qual a idade da " + p + "ª Pessoa: ");
                id = Convert.ToInt32(Console.ReadLine());
                p++;

                if (id >= 18)
                {
                    m_id = m_id + 1;

                }
            }
            Console.WriteLine("O número de pessoas maiores de 18 anos é: " + m_id);
            Console.ReadKey();

        }//fim