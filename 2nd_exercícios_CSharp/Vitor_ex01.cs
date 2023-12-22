namespace Ex01
{

        internal class Program
        {
            static void Main(string[] args)
            {//inicio
                double r, area, diam, per;


                Console.WriteLine("Digite o Raio: ");
                r = Convert.ToDouble(Console.ReadLine());


            diam = 2 * r;
            area = Math.PI * Math.Pow(r,2);
            per = 2 * Math.PI * r;


                Console.WriteLine("Diâmetro: " + diam);
                Console.WriteLine("Área: " + area);
                Console.WriteLine("Perímetro: " + per);

            Console.ReadKey();
            }//fim
        }
    }