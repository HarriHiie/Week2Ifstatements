using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kautaja käest sisestada tema lemmik värvi
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline"
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas"
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber"
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled ükssavik"

            Console.WriteLine("Mis on su lemmik värv?");
            string Usercolor = Console.ReadLine().ToLower();;
            if (Usercolor == "punane")
            {
                Console.WriteLine("Oled Romantiline");
            }
            if (Usercolor == "Sinine")
            {
                Console.WriteLine("Oled Töökas");
            }
            if (Usercolor == "Roheline");
            {
                Console.WriteLine("Oled Looduse sõber");
            }
            if (Usercolor == "midagi muud") ;
            {
                Console.WriteLine("Oled Ükssarvik");
            }












        }
        }
 }
