using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Roman_app
    {
        public class RomanNumeralsClass
        {
            public void GatherRomanInput()
            {

                Console.WriteLine("Ange en romersk siffra:");
                string roman = Console.ReadLine().ToUpper();

                if (roman.Length > 11)
                {
                    Console.WriteLine("Fel: Strängen är för lång.");
                    return;
                }

                // Kontrollera om strängen innehåller endast giltiga tecken
                foreach (char c in roman)
                {
                    if (!"IVXLCDM".Contains(c))
                    {
                   
                    Console.WriteLine("Fel: Ogiltiga tecken.");
                        return;
                    }
                }
                // Anropa konverteringsmetoden och visa resultatet

                Console.WriteLine($"Det decimala värdet är: {RomanToInt(roman)}");
            }

            public int RomanToInt(string s)
            {
                // Använd en Dictionary för att mappa romerska tecken till decimala värden

                Dictionary<char, int> romanMap = new Dictionary<char, int>
                    {
                        {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
                    };

                int total = 0;

                // Konverteringslogik med en enkel loop

                for (int i = 0; i < s.Length; i++)
                {
                    // Om nästa värde är större, subtrahera nuvarande, annars addera

                    if (i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i + 1]])
                    {
                        total -= romanMap[s[i]];
                    }

                    else
                    {
                        total += romanMap[s[i]];
                    }
                }
                return total;

            }
        }
    }


            
