using System.Text;
using System.Threading.Tasks;

namespace MethotApp
{
    // Bu bir içiçe string metot uygulamasıdır
    class Program
    {
        static void Main(string[] args)
        {
            string text = text3();
            Console.WriteLine(text);
        }
        public static string text1() 
        {
            string a = "My name is ";
            return a;
        }
        public static string text2() 
        {
            string b = "Batuhan.";
            return b;
        }
        public static string text3() 
        {
            string ab = text1() + text2();
            return ab;
        }
    }
}
