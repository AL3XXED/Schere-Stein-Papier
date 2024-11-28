using System.Reflection.Metadata.Ecma335;

namespace Schere_Stein_Papier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wähle: 1 für Schere, 2 für Stein, 3 für Papier");
            int spielerWahl = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int computerWahl = rnd.Next(1, 4);

            Console.WriteLine("Du wählst: " + auswahl(spielerWahl));
            Console.WriteLine("Computer wählt: " + auswahl(computerWahl));

            if (spielerWahl == computerWahl)
            {
                Console.WriteLine("Unentschieden!");
            }
            else if ((spielerWahl == 1 && computerWahl == 3) || (spielerWahl == 2 && computerWahl == 1) || (spielerWahl == 3 && computerWahl == 2))
            {
                Console.WriteLine("Du gewinnst!");
            }
            else
            {
                Console.WriteLine("Computer gewinnt!");
            }
            string auswahl(int wahl)
            {
                switch (wahl)
                {
                    case 1: return "Schere";
                    case 2: return "Stein";
                    case 3: return "Papier";
                    default: return "Ungültig";
                }
            }

        }
    }
}
