using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem, kui 18 siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhilube saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju Õnne! Nüüd sa saad juhilube taotleda"

            Console.WriteLine("Palun, sisesta enda sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2022 - yearOfBirth;
            if (userAge > 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");

            }

            else if (userAge > 18)

            {
                Console.WriteLine("oled piisavalt vana, et juhilube saada.");
            }

            else
            {
                Console.WriteLine("Palju Õnne! Nüüd sa saad juhilube taotleda.");

            }

        }
    }
}
