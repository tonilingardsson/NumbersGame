using System;

namespace NumbersGame
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Boolean to know if the game is on or not
            bool gameOn = true;

            // TODO While

            // First user interaction to start playing
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Console.WriteLine("Välj svårighetsgrad: 1 (lätt: 1-10), 2 (medel: 1-50), 3 (svår: 1-100)");
            
            // Save the user input into a integer
            int difficulty = int.Parse(Console.ReadLine());

            // Declare playerWon boolean, Main scope
            bool playerWon = false;
            
            // 3 diffilcuty levels
            if (difficulty < 1 || difficulty > 3) 
            {
                // Wrong user input, bye msg
                Console.WriteLine("haha... Det var mellan 1 och 3. Hej då!");
                return;
            }
            // Dificulty values
            else if (difficulty == 1) 
            {
                playerWon = CheckGuess(1, 10);
            } 
            else if (difficulty == 2) 
            {
                playerWon = CheckGuess(1, 50);
            } 
            else 
            {
                playerWon = CheckGuess(1, 100);
            }

            // Win-lose msg
            if (playerWon) {
                Console.WriteLine("🎉 Du vann spelet!");
            }
            else {
                Console.WriteLine("💩 Du förlorade den här gången.");
            }
        }
        static bool CheckGuess(int min, int max) {
                // Generate a random number between min and max (inclusive) according to the chosen difficulty level
                int SecretNumber = new Random().Next(min, max + 1);
                // Allow the user to guess up to 5 times
                for (int attempts = 1; attempts <= 5; attempts++) {
                    // Prompt the user to enter their guess
                    Console.WriteLine($"Försök {attempts} av 5: gissa numret mellan {min} och {max}");
                    int userGuess = int.Parse(Console.ReadLine());
                    // Check if the user's guess is correct
                    if (userGuess == SecretNumber) {
                        Console.WriteLine("Wohoo! Du gjorde det!");
                        return true;
                    }
                    // Msg to user when guess is wrong
                    else if (userGuess < SecretNumber) {Console.WriteLine("|o| Tyvärr du gissade för lågt!");}
                    else {Console.WriteLine("|o| Tyvärr du gissade för högt!");}
                }
                // Msg to user when attempts = 0
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                return false;
            }
        }
}