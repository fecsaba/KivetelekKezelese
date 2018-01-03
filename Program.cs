using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KivételKezelés
{
    class Program
    {
        public static bool Ex(string inp, int a) 
        {
            bool hiba = true;
            
                try
                {
                    
                    //a = int.Parse(inp);
                    if (!int.TryParse(inp, out a))
                    {

                        throw new Exception("El...tad ");
                    }
                    else hiba = false;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            return hiba;
            

        }
        static void Main(string[] args)
        {
            string inp;
            int a=0;
            int b = 0;

            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine(a);
            /*********************************************************/
            //try
            //{
            //    a = int.Parse(Console.ReadLine());
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("El...tad");
            //}

            //Console.WriteLine(a);
            /**********************************************************/
            bool error = false;
            do
            {
                Console.Write("Kérek egy számot: ");
                inp = Console.ReadLine();
                error = Ex(inp, a);
            } while (error);
            a = int.Parse(inp);

            
            Console.WriteLine(a);
            do
            {
                Console.Write("Kérek egy másik számot: ");
                inp = Console.ReadLine();
                error = Ex(inp, b);
            } while (error);
            b = int.Parse(inp);


            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
