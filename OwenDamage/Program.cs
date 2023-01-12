﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwenDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();
            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anythingelse to quit: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key!='1' && key != '2' && key != '3') return;
                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.Roll = roll;
                swordDamage.SetMagic(key == '1' || key == '3');
                swordDamage.SetFlaming(key == '2' || key == '3');
                Console.WriteLine($"\nRolled {roll} for {swordDamage.Damage} HP\n");
            }
            
        }
    }
}
