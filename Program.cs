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
                Console.WriteLine("haha... Det var mellan 1 och 3. Hej då!");
                return;
            }
            else if (difficulty == 1) 
            {
                CheckGuess(1, 10);
            } 
            else if (difficulty == 2) 
            {
                CheckGuess(1, 50);
            } 
            else 
            {
                CheckGuess(1, 100);
            }
            static void CheckGuess(int min, int max) {
                // Generate a random number between min and max (inclusive) according to the chosen difficulty level
                int SecretNumber = new Random().Next(min, max + 1);
                // Allow the user to guess up to 5 times
                for (int attempts = 1; attempts <= 5; attempts++) {
                    // Prompt the user to enter their guess
                    System.Console.WriteLine($"Försök {attempts} av 5: gissa numret mellan {min} och {max}");
                    int userGuess = int.Parse(Console.ReadLine());
                    // Check if the user's guess is correct
                    if (userGuess == SecretNumber) {
                        Console.WriteLine("Wohoo! Du gjorde det!");
                    }
                    else if (userGuess < SecretNumber) {Console.WriteLine("|o| Tyvärr du gissade för lågt!");}
                    else {Console.WriteLine("|o| Tyvärr du gissade för högt!");}
                }
                System.Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }
        }
    }    
}