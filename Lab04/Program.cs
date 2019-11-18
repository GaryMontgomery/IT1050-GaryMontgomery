using System;

namespace Lab04
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 100; ++i)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("This number is even");
                    Console.WriteLine();
                    
                }
                else
                {   
                    Console.WriteLine(i);                 
                    Console.WriteLine("This number is odd");
                    Console.WriteLine();
                    
                }
            }
            Console.WriteLine();

            Console.Write("Enter temperature: ");

            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 90) { Console.WriteLine("Fish"); }
            else if (temp >= 80) { Console.WriteLine("Lion"); }
            else if (temp >= 70) { Console.WriteLine("Turtle"); }
            else if (temp >= 60) { Console.WriteLine("Deer"); }
            else if (temp >= 50) { Console.WriteLine("Reindeer"); }
            else if (temp >= 40) { Console.WriteLine("Moose"); }
            else if (temp >= 20) { Console.WriteLine("Penguin"); }
            else if (temp >= 10) { Console.WriteLine("Polar Bear"); }
            else { Console.WriteLine("Bug"); }
            Console.WriteLine();

            int j = 10;
            while (j < 21)
            {
                Console.WriteLine(j);
                ++j;
            }
            Console.WriteLine();

            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }
        }
    }
}

//The four basic components of a counter-controlled repetition are the initialization, loopContinuationCondition, increment, and statement
// Initialization names the loop control variable and sets its initial value
// The loopContinuationCondition checks and determines if the loop should continue
// The increment moddifies the value of the control variable for every loop
// The statement is something that happens as the loop continues, i.e. Console.Write($"{counter

// While statements are used for sentinel-controlled iteration, and for statements are used for counter-controlled iteration.
// Both statements can be used for both iterations, however, and for statements can specify the elements of counter-controlled iterations in a single line.

