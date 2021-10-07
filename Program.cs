using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // DATE TIME //
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // STRING //
            string str1 = string.Empty;
            str1 = "Tunahan Serilmez";
            string ad = "Tunahan ";
            string soyad = "Serilmez";
            string tamisim = ad + soyad;
            Console.WriteLine(tamisim);

            // INTEGER //
            int integer1 = 3;
            int integer2 = 5;
            int integer3 = integer1 * integer2;
            Console.WriteLine(integer3);

            // DEĞİŞKEN DÖNÜŞÜMLERİ //
            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);


            Console.ReadKey();
        }
    }
}
