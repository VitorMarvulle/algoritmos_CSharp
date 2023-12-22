        {//inicio

            int[] nums = new int[21];            

            for (int i = 1; i < nums.Length; i++)
           
            {
                Console.WriteLine("Digite o " + i + "º número: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(nums);
            Console.WriteLine("MENOR NÚMERO DIGITADO: " + nums[0]);
            Console.WriteLine("MAIOR NÚMERO DIGITADO: " + nums[20]);
            Console.ReadKey();
        }//fim