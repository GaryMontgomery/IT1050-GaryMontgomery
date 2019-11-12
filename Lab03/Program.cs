using System;

namespace Lab03
{
    
    class Program /*Single-selection statements and "while" repetition statements are similar in that they both execute an action.  
        They differ in that while repitition statements can repeatedly execute indefinitely while a statement is ture*/
     
    {
        static void Main(string[] args)
        {
            int speedLimit = 35;
            int speed = 42;
            double tempF;  //degrees Farenheit
            double tempC;  //degrees Celsius

            bool isTrue = true;
            bool isFalse = false;

            if (speed > speedLimit)
                Console.WriteLine("SLOW NOW");

            if (isTrue == true)
                Console.WriteLine("It is true!");
            if (isFalse == false)
                Console.WriteLine("It is false!");

            Console.Write("Enter temperature in degrees Farenheit: ");

            tempF = Convert.ToDouble(Console.ReadLine());

            tempC = (tempF - 32) * 5 / 9;

            Console.WriteLine(tempC);

            int x = 1;
            while (x < 10)
                x++;
            Console.Write(x);

            int y = 60;
            while (y > 20)
                y -= 5;
            Console.WriteLine(y);

            int z = 10;
            while (z < 20)
                z += 2;
            Console.WriteLine(z);
        }
    }
}
