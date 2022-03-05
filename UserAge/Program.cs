using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"oled sündinud aastat (yearOfBirth)"
            Console.WriteLine("Palun, sisesta enda vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            int yearOfBirth = 2022 - userAge;
            Console.WriteLine($"Oled sündinud  +{yearOfBirth} aastal.");
        }
    }
}
