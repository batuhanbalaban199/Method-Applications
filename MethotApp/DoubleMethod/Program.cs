using System.Text;
using System.Threading.Tasks;

namespace MethotApp
{
    // Bu bir içiçe metot uygulamasıdır
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = Calculation3();
            Console.WriteLine("İçiçe Metotların Sonucu = " + sonuc);
        }
        public static int Calculation1()
        {
            int sayi1 = 12;
            int sayi2 = 13;
            int sayi3 = 14;
            int sayi4 = 15;
            int sayi5 = 16;
            int toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;
            return toplam;
        }
        public static int Calculation2()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int sum = a+ b + c + d + e;
            return sum;
        }

        public static int Calculation3() 
        {
            int esastoplam = Calculation1() + Calculation2();
            return esastoplam;
        }

    }
} 
