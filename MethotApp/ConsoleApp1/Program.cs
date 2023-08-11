using System.Text;
using System.Threading.Tasks;

namespace MethotApp
{
    // Bu bir metot uygulamasıdır
    class Program
    {
        public static double CircumferenceOfCircle() 
        {
            Console.Write("Yarıçapı Girin : ");
            double r = Convert.ToDouble(Console.ReadLine());
            double pi = 3.1415;
            double Circumference = 2 * pi * r;
            return Circumference;
        }
        private static int Calculate()
        {
            Console.Write("Kısa Kenarı Girin :");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun Kenarı Girin :");
            int uk = Convert.ToInt32(Console.ReadLine());
            int alan = kk * uk;
            return alan;
        }
        static void Main(string[] args) 
        {
            int area = Calculate();
            double circumference = CircumferenceOfCircle();
            Console.WriteLine("Alan = " + area);
            Console.WriteLine("Dairenin Çevresi = " +  circumference);
            Console.ReadKey();

        }
    }
}
