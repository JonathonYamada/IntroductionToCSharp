using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        { /*Create a console application which will ask the user to enter a year in the format of YYYY (i.e. 2012, 2010, or 1999). 
            If the user enters an invalid year format for example 12, -2, 99, then the program shows the message: You entered an invalid year format
            The program continues to ask the user to enter a valid year format.
            The program will then determine if the year entered is a leap year or not. 
            If the year entered by the user is a leap year, the program shows an appropriate message. 
            Sample message is given below:
            The year 2012 is a leap year
            If the year entered is not a leap year, then show an appropriate message. Sample message is given below: 
            The year 2010 is not a leap year. 

            //Declaration of variables
            string year;
            int yearLength;
            bool continueIteration = true;

            // default value needs to be assigned
            int verifyNumber = 0;

            while (continueIteration == true)
            {
                Console.Write("Enter a year: ");
                year = Console.ReadLine();
                yearLength = year.Length;

                try
                {
                    verifyNumber = Int32.Parse(year);
                }
                // Catches exception in a nice way so code doesnt break you know? - simonMelouah
                catch
                {
                    Console.WriteLine("Invalid date format [using the tryCatch method]\nTry again");
                    Console.ReadLine();

                    // While loop check point, restarts the while loop
                    continue;
                }

                if (yearLength == 4)
                {
                    
                    if (verifyNumber % 4 == 0)
                    {
                        Console.WriteLine("The year {0} is a leap year", year);
                    }
                    else
                    {
                        Console.WriteLine("The year {0} is not a leap year", year);
                    }
                    Console.ReadLine();
                    continueIteration = false;
                }
                else
                {
                    Console.WriteLine("You entered an invalid year format[using the if/else statement]\nTry Again");
                    Console.ReadLine();
                    continue;
                }
            }*/

            int lives = 3, guess, n =10;
            
            bool loop = true;

            while (loop == true)
            {
                if (lives == 0)
                {
                    Console.WriteLine("Game Over, the secret number was {0}", n);
                    Console.ReadLine();
                    break;
                }

                else if (lives != 0)
                {
                    Console.Write("Guess a number between 0 and 20:  ");
                    int.TryParse(Console.ReadLine(), out guess);
                    if (guess == 10)
                    {
                        Console.WriteLine("Well done, you guessed correctly, the answer is {0}", n);
                        Console.ReadLine();
                    }


                    if (guess < n)
                    {
                        if (guess < 0)
                        {
                            Console.WriteLine("Make sure your value is between 0 ane 20");
                            Console.ReadLine();
                            continue;
                        }
                        lives -= 1;
                        Console.WriteLine("Your guess is too low, try again. You have {0} guesses remaining", lives);
                        Console.ReadLine();
                        continue;
                    }
                    else if (guess > n)
                    {
                        if (guess > 20)
                        {
                            Console.WriteLine("Please make sure your value is bewteen 0 and 20");
                            Console.ReadLine();
                            continue;
                        }
                        lives -= 1;
                        Console.WriteLine("Your guess is too high, try again. You have {0} guesses remaining", lives);
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        loop = false;
                    }

                }
            }








        }
        }
    }

