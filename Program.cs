using System;

namespace Deliverable_2_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for user input
            Console.Write("Enter an integer value between 1 and 100 to execute an iterative statement:"); 
            try
            {
                //this variable will gather data from user input
                string input = Console.ReadLine();
                //This variable will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                /*if/else Deliverable_2_Iterative_Statements is used to test the values of user input*/
                if ((value_of_input >0)&&(value_of_input < 101))
                {
                    Console.WriteLine("You have entered "+ value_of_input.ToString());
                    //For Loop
                    for (int i = 0; i <value_of_input; i++)
                    {
                        Console.WriteLine( "This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer between 1 and 100 and try again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}
