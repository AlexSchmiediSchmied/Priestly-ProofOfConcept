using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriestlyProofOfConcept
{
    internal class Program
    {
        //Project start: 04.04.24
        //By: A.Y. Schmied :)
        /*TODO:
         - Add character selection []
         - Add intro []
         - Add stat bars []
         - Add fight system []
         - Add enemy 1 -> Demon Lvl. 1 []
         - Add enemy 2 -> Heretic Lvl. 1 []*/
        static void Main(string[] args)
        {
            MchoosePriestOrPriestess();

            MwhichChoiceActive(out string choiceCharacter);

            Console.WriteLine();

            Console.WriteLine("Welcome " + choiceCharacter + "!");

            Console.ReadLine(); 
        }

        static void MchoosePriestOrPriestess()
        {
            string optionPriest = "Priest";
            string optionPriestess = "Priestess";

                Console.WriteLine("Do you want to play as a Priest or Priestess?");
                Console.WriteLine("(Use arrow keys to navigate, and press enter)");                         
        }

        static void MwhichChoiceActive(out string choiceCharacter)
        {
            bool choicePriest = true;
            bool choicePriestess = false;

            string optionPriest = "Priest";
            string optionPriestess = "Priestess";
            string auxString = "";


            while (true)
            {/*Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(optionPriest);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" | " + optionPriestess);
                auxString = optionPriest;*/

                if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
                {
                    choicePriest = false;
                    choicePriestess = true;

                    Console.Clear();

                    Console.WriteLine("Do you want to play as a Priest or Priestess?");
                    Console.WriteLine("(Use arrow keys to navigate, and press enter)");

                    Console.Write(optionPriest + " | ");
                    
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write(optionPriestess);

                    Console.ForegroundColor = ConsoleColor.Gray;

                    auxString = optionPriestess;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
                {
                    choicePriest = true;
                    choicePriestess = false;
                    
                    Console.Clear();

                    Console.WriteLine("Do you want to play as a Priest or Priestess?");
                    Console.WriteLine("(Use arrow keys to navigate, and press enter)");

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write(optionPriest);

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write( " | " + optionPriestess);

                    auxString = optionPriest;
                }
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                //check and output the true choice                
            }
            choiceCharacter = auxString;         
        }
    }
}
