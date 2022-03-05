using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDate
{
    class Program
    {
        private static object userAge;

        static void Main(string[] args)
        {
            //program küsib kasutaja sünniaastat;
            //program arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolist;

            Console.WriteLine("Palun, sisesta enda sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

           //Console.WriteLine("Oled " + userAge + " aastat vana.");
           //string interpolation
            Console.WriteLine($"Oled  {userAge} aastat vana.");






        }
    }
}
