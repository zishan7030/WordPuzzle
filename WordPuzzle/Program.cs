using System;
using System.Linq;
using System.Collections;
namespace WordPuzzle
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Welcome to the game WORD PUZZLE");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Create Words Of Three Or More Letters From The Word: MASTER ");
            Console.ResetColor();
            Console.WriteLine("\t=========Instructions=========");
            Console.WriteLine("\ti.Please enter the words in uppercase.");
            Console.WriteLine("\tii.Every correct word will add 1 point to your score.");
            Console.WriteLine("\tiii.In order to quit from game , type ‘QUIT’.");
            //Declaring The List Of String
            string[] words = new string[]{"TAE","TEA","EMS","ERA","EASTER","TAM","ATE","EAT","ARE","EAR","ARM","ART","TAS","ERS","ARS","MAR","RET","RAM","RES","REM","MAS","MAT","MET","RAT","RAS","SAE","SAT","SET","SER","ETA","SEA","MAE" };
            //Declarin Count for user points.
            int count = 0;
            
            // Enhance Loop
            foreach (string m in words)
            {
                Console.Write("Please Enter The Word: ");
                string i = Console.ReadLine();
                if (i.Any(char.IsLower))
                {
                    Console.WriteLine("Your Answer Should be In Upper Case");
                }

                else if (i == "QUIT")
                {
                    Console.WriteLine("Thank You\n Your Score is {0}:",count);
                    break;
                }
                else if (words.Contains(i) == true)
                {
                    Console.WriteLine("correct");
                    count++;
                    Console.WriteLine("1 Point Total Pints: {0}",count);

                }
                else
                {
                    Console.WriteLine("incorrect");
                }
                
            }

        }
    }
}