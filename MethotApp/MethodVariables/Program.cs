using System.Text;
using System.Threading.Tasks;

namespace MethotApp
{
    // Bu bir değişkenli metot uygulamasıdır.
    class Program
    {
        static int n;
        static void Main(string[] args)
        {
            Console.Write("Number to get squared = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your Answer = " + sqr(n));
            Console.Write('\n');
            Console.Write("Number to ge Sqrt = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your Answer =" + sqrt(n));
        }

        static int sqr(int x) 
        {
            int y;
            y = x * x;
            return y;
        }
        static int sqrt(int x) 
        {
            int y;
            y = Convert.ToInt32(Math.Sqrt(x));
            return y;
        }
    }
}