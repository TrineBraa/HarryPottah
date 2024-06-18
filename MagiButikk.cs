using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HarryPottah
{
    internal class MagiButikk
    {
        private Heks _witch;
        public List<string> _animals;
        public List<string> _wands;

        public MagiButikk(Heks witch)
        {
            _witch = witch;
            _animals = new List<string>()
            {
                "Owl",
                "Rat",
                "Cat",
            };
            _wands = new List<string>()
            {
                "Phoenix wand",
                "Unicorn Wand",
                "Troll wand",
            };

        }

        public void ShowShop()
        {
            bool Shopping = true;
            while (Shopping)
            {
                Console.WriteLine("Welcome to the shop, here you can shop different things!");
                Console.WriteLine("1. Animals");
                Console.WriteLine("2. Wands");
                Console.WriteLine("3. Exit shop");
                var UserInput = Console.ReadLine();
                
                    switch (UserInput)
                {
                    case "1":
                        ShopAnimal();
                        break;
                    case "2":
                        ShopWands();
                        break;
                    case "3":
                        Shopping = false;
                        break;
                    default:
                        Console.WriteLine("Please input a valid option");
                        break;
                }

            }
        }


        public void ShopAnimal()
        {
            foreach (string Creature in _animals)
            {
                Console.WriteLine(Creature);
            }

            Console.WriteLine("Do you want to buy an animal?");
            string Animal = Console.ReadLine().ToLower();
            if (Animal == "owl")
            {
                _witch.BuySomething("Owl");
            }
            else if (Animal == "rat")
            {
                _witch.BuySomething("Rat");
            }
            else if (Animal == "cat")
            {
                _witch.BuySomething("Cat");
            }

        }


        public void ShopWands()
        {
            foreach (string Wands in _wands)
            {
                Console.WriteLine(Wands);
            }

            Console.WriteLine("Do you want to buy a wand?");
            string Wand = Console.ReadLine().ToLower();
            if (Wand == "Phoenix Wand".ToLower())
            {
                _witch.BuySomething("Phoenix Wand");
            }
            else if (Wand == "Unicorn Wand".ToLower())
            {
                _witch.BuySomething("Unicorn Wand");
            }
            else if (Wand == "Troll Wand".ToLower())
            { 
                _witch.BuySomething("Troll Wand");
            }
        }



    }
}





