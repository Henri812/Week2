﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm kontrollib, kas kasutaja on vanem kui või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib instagram`i kasutada
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor.

            Console.WriteLine("Palun, sisesta oma vanus:");
            int userAge = Convert.ToInt32 (Console.ReadLine());

            if(userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et instagrammi kontot luua.");

            }

            else if(userAge < 13)

            {

                Console.WriteLine("Oled liiga noor, et instagrami kontot luua.");

            }
            else
            {

                Console.WriteLine("Oledki 13, nüüd saad endale instagrammi kontot luua.");

            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
