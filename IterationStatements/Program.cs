namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void ReverseCount()
        {
            for (int i = 1000; i <= 1000 && i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void SkipThree()
        {
            for (int i = 3; i <= 999; i = i + 3)
            {
                Console.WriteLine(i);

            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool EqualOrNot(int num1, int num2)
        {
            return num1 == num2;
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num)
        {

            string result = (num % 2 == 0) ? $"{num} is even" : $"{num} is odd";
            Console.WriteLine(result);
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int num)
        {
            switch (num)
            {
                case 0:
                    Console.WriteLine("0 is neither negative or positive");
                    break;
                case < 0:
                    Console.WriteLine("The number is negative");
                    break;
                case > 0:
                    Console.WriteLine("The number is positive");
                    break;
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VoterEligible()
        {
            int age = 0;
            bool isNumber;

            do
            {
                Console.WriteLine("Enter your age:");
                var response = Console.ReadLine();
                isNumber = int.TryParse(response, out age);
            } while (isNumber == false);

            if (age < 18)
                Console.WriteLine("You are not eligible to Vote. Come back when you are 18.");
            else if (age >= 18 && age< 30)
                Console.WriteLine("You are eligible to vote.");
            else 
                Console.WriteLine("You're old enough to know you can vote by now.");
                  
         }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void NegativeToPositiveTen()
        {
            int number = 0;
            bool isNumber;

            do
            {
                Console.WriteLine("Enter your number:");
                var response = Console.ReadLine();
                isNumber = int.TryParse(response, out number);
            } while (isNumber == false);

            if (number <= 10 && number >= -10)
                Console.WriteLine("The number is within the range of -10 to 10.");
            else
                Console.WriteLine("The number is out of range.");
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            int number = 0;
            bool isNumber;

            do
            {
                Console.WriteLine("Enter your number:");
                var response = Console.ReadLine();
                isNumber = int.TryParse(response, out number);
            } while (isNumber == false);
            Console.WriteLine();
            for(int i = 1; i < 12; i++)
            {
                Console.WriteLine($"{number} * {i} = {(number * i)}");
            }
        }

            //Call the methods to test them in the Main method below
            static void Main(string[] args)
        { 
            // Uncomment code beneath 'Method #' to run

            /*---------------------
              LukeWarm Section
            ----------------------*/

            // Method 1
            //ReverseCount();


            // Method 2
            //SkipThree();


            // Method 3
            //int x = 4;
            //int y = 4;
            //bool result = EqualOrNot(x, y);
            //Console.WriteLine(result);


            // Method 4
            //int number = 45;
            //EvenOrOdd(number);


            // Method 5
            //int positive = 2;
            //int negative = -3;
            //int zero = 0;
            //PositiveOrNegative(positive);
            //PositiveOrNegative(negative);
            //PositiveOrNegative(-positive);
            //PositiveOrNegative(zero);

            //Method 6
            //VoterEligible();

            /*------------------------
              Heatin' Up Section
            --------------------------*/

            //Method 1
            //NegativeToPositiveTen();

            //Method 2
            //MultiplicationTable();
        }
    }
}
