namespace Ex02
{

        internal class Program
        {
            static void Main(string[] args)
            {//inicio
                double a, b, c, x1, x2, raiz, delta;


                Console.WriteLine("Digite o valor de 'a': ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor de 'b': ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor de 'c': ");
                c = Convert.ToDouble(Console.ReadLine());


            delta = Math.Pow(b,2)-4*a*c;
            raiz = Math.Sqrt(delta);
            x1 = ((-b) + raiz) / 2 * a;
            x2 = ((-b) - raiz) / 2 * a;


            Console.WriteLine(a);
            Console.WriteLine("X1: " + x1);
            Console.WriteLine("X2: " + x2);


            Console.ReadKey();
            }//fim
        }
    }