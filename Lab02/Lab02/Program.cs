using System;

namespace Lab02
{
    public class Welcome  //A class is a collection of properties and methods.  An object is something that inherits the properties and methods of the class it is identified with.  
    {
        public static void Main(string[] args) //The C# application executes at this point, the Main method.
        {
            int number1; //The difference between an int and a double is that ints are whole numbers wheras floats and doubles can be decimals with more precision.  
            int number2;
            int product;

            Console.Write("Enter first integer: ");

            number1 = Convert.ToInt32(Console.ReadLine());

            /*Like we have types double and int, we can create our own custom types using Classes.  Each class has variables called instance variables or class members.  
            To read the value of an instance variable, we create method called a get accessor.  To assign a value ton instance variable, we use a method called a set accessor.*/

            Console.WriteLine("Enter second integer: ");

            number2 = Convert.ToInt32(Console.ReadLine());

            // Example of a method: public void SetName(string accountName)

            product = number1 * number2;

            Console.WriteLine("Product is {0}", product);

            Console.WriteLine("{0}\n{1}", "Hello World!", "From Gary");

            Console.WriteLine("{0}\t{1}", "Hello World!", "From Gary");
        }
    }
}
