/*Name: Alanis Correa Kriener
  Purpose: Practice 'for', 'while' and 'do/while' loop.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3class2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            // MENU
            string input = "n";

            do
            {

                Console.WriteLine(">>>> MENU <<<<\nMultiplier: press 1\nTimes table: press 2\nSquares and cubes: press 3");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    // Task 1 - Multiplier
                    Console.WriteLine("N \t\tN*10\t\tN*100\t\tN*1000\n");
                    Console.WriteLine(">>> for loop <<<");
                    for (int i = 3; i < 8; i++)
                    {
                        Console.WriteLine($"{i}\t\t{i * 10}\t\t{i * 100}\t\t{i * 1000}");
                    }

                    Console.WriteLine("\n>>> while loop <<<");
                    int b = 3;
                    int finish = 7;
                    while (b <= finish)
                    {
                        Console.WriteLine($"{b}\t\t{b * 10}\t\t{b * 100}\t\t{b * 1000}");
                        b++;
                    }

                    Console.WriteLine("\n>>> do while loop<<<");
                    int c = 3;
                    do
                    {
                        Console.WriteLine($"{c}\t\t{c * 10}\t\t{c * 100}\t\t{c * 1000}");
                        c++;
                    } while (c <= finish);
                    
                }
                else if (option == 2)
                {
                    // Task 2 - Times Table
                    Console.WriteLine("Please enter a number to display the times table using multipliers 1 though 12.");
                    int userNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(">>> for loop <<<");
                    for (int i = 1; i < 13; i++)
                    {
                        Console.WriteLine($"{i} x {userNum} = {i * userNum}");
                    }

                    Console.WriteLine("\n>>> while loop <<<");
                    int b = 1;
                    int finish = 12;
                    while (b <= finish)
                    {
                        Console.WriteLine($"{b} x {userNum} = {b * userNum}");
                        b++;
                    }

                    Console.WriteLine("\n>>> do while loop <<<");
                    b = 1;
                    do
                    {
                        Console.WriteLine($"{b} x {userNum} = {b * userNum}");
                        b++;
                    } while (b <= finish);

                } 
                else if (option == 3)
                {
                    Console.WriteLine("***TASK UNDER CONSTRUCTION***");
                }
                else
                {
                    Console.WriteLine("Sorry, that input was invalid.");
                }

            Console.WriteLine("Would you like to return to the menu? (Y/N)");
            input = Console.ReadLine().ToLower();
            } while (input != "n");

        }
    }
}
