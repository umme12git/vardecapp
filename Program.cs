using System;

namespace vardecapp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string myCarName = "toyota";
            int myCarAge = 5;
            char myCarColLetter = 'R';
            bool myCarCondNew = true;
            double myCarCost = 21000.58;
            decimal myCarCurrVal = 17000.40m;


            Console.WriteLine("Here is the informaiton about my car");
            Console.WriteLine($"My car name is {myCarName}, my car is {myCarAge} years old, first letter of my car's color is {myCarColLetter}");
            Console.WriteLine($"The condition of my car is (new -True  old -False) {myCarCondNew}");
            Console.WriteLine($"The cost of my car was ${myCarCost}, my car's current value is ${myCarCurrVal}");



        }
    }
}
