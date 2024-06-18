using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HarryPottah
{
    internal class Heks
    {
        public string _name;
        public string _house;
        public List<string> _inventory ;

        public Heks(string Name, string House)
        {
            _name = Name;
            _house = House;
            _inventory = new List<string>();
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"House: {_house}");
            Console.WriteLine($"Inventory: ");
            PrintInventory();
        }

        public void BuySomething(string Item)
        {
            _inventory.Add(Item);
        }

        public void PrintInventory()
        {
            foreach (var Item in _inventory)
            {
                Console.WriteLine(Item);
            }
        }


        public void CastMagic()
        {
            bool Casting = true;
            while (Casting)
            {
                Console.WriteLine("Here you can cast some magic!");
                Console.WriteLine("\tYou only know two spells yet!");

                Console.WriteLine("Vingardium Leviosa");
                Console.WriteLine("Hokus Pokus");
                Console.WriteLine("\t exit to leave the spellcasting!");

                var SpellName = Console.ReadLine();
                if (SpellName.ToLower() == "vingardium leviosa")
                {
                    Console.WriteLine("\na feather floats in the air infront of you! Good job!");
                }
                else if (SpellName.ToLower() == "hokus pokus")
                {
                    Console.WriteLine("\nYou set of fireworks as planed! Well done");
                }
                else if (SpellName.ToLower() == "exit")
                {
                    Console.WriteLine("\nYou leave the spellcasting!");
                    Casting = false;
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("\nYou fail casting the spell! Try again!");
                }





            }
        }













    }
}
