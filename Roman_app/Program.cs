
namespace Roman_app
    {
        public class Program
        {
            static void Main(string[] args)
            {

            // Just for fun!
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); // Detta uppdaterar hela konsolen med den nya bakgrundsfärgen

            Console.ForegroundColor = ConsoleColor.Black;

            // Skapa ett objekt av klassen och anropa metoden för att hämta input

            RomanNumeralsClass romanConverter = new RomanNumeralsClass();
            romanConverter.GatherRomanInput();
        }
    }
}
    
