using System;

namespace NumbersGame
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Console.WriteLine("Välj svårighetsgrad: 1 (lätt: 1-10), 2 (medel: 1-50), 3 (svår: 1-100)");
            int difficulty = int.Parse(Console.ReadLine());
            if (difficulty < 1 || difficulty > 3) 
            {
                Console.WriteLine("Ogiltig svårighetsgrad. Programmet avslutas.");
                return;
            }
            else if (difficulty == 1) 
            {
                PlayGame(1, 10);
            } 
            else if (difficulty == 2) 
            {
                PlayGame(1, 50);
            } 
            else 
            {
                PlayGame(1, 100);
            }
            
        }
    }    
}