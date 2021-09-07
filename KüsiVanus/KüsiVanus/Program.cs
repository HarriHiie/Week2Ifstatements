using System;

namespace KüsiVanus
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, et kas ta on piisvalt vana
            //et juhilubasaada
            Console.WriteLine("Mis Aastal sa sündisid");

            int Age = Int32.Parse(Console.ReadLine());

            if (Age > 2003)

            Console.WriteLine(".");

            Console.WriteLine("Kui vana sa oled");

            int Age = Int32.Parse(Console.ReadLine());

            if (Age < 18)

                Console.WriteLine("Oled Liiga Noor");






        }
    }
}
