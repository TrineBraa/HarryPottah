//Du skal starte med å lage en harrypotter character klasse med egenskaper som navn, house, inventory (ex wand eller pet)

//Få applikasjonen til å printe ut en introduksjon for karakteren, som sier noe om hva de heter, hvilket hus de er medlem av og hvilke items de har

//Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:  ugle, rotte eller en katt. De har også mulighet til å kjøpe en tryllestav: føniksstav, unikornstav eller trollstav. For å få til dette må du lage en egen klasse som er butikken, og presentere brukeren med en meny for hva personen skal kjøpe.

//Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren, og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
//trylleformler: 
//vingardium leviosa(får en fjær til å fly)
//hokus pokus(fyrer av fyrverkerier)

using System.Runtime.InteropServices;
using HarryPottah;


//    Karaktern trylle



Heks witch = new Heks("Trine", "Hufflepuff");
MagiButikk Shop = new MagiButikk(witch);

Main();

void Main()
{
    Console.WriteLine($"Welcome {witch._name}");
    
    while (true)
    {
        Console.WriteLine("\n Your information: ");
        witch.PrintInformation();
        Console.WriteLine();
        Console.WriteLine("\n You have some options to what you can do!");
        Console.WriteLine("1.Go shopping");
        Console.WriteLine("2 Go cast magic");
        Console.WriteLine("3.Exit");
        MainMenu();
    }



};


void MainMenu()
{
    var Option = Console.ReadLine();
    switch (Option)
    {
        case "1":
            Shop.ShowShop();
            break;
        case "2":
            witch.CastMagic();
            break;
        case "3":
            Environment.Exit(404);
            break;
        default:
            Console.WriteLine("Please input a valid option");
            break;
    }

}


