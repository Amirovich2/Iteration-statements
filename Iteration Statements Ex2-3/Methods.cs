namespace Iteration_Statements_Ex2_3
{
    internal class methods
    {
        public static void num1000()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void num999()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);

            }
        }
        public static void choose1(int num1)
        {

            if (num1 % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
                Console.WriteLine("This number is odd");
        }

        public static void choose2(int num2)
        {

            if (num2 % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
                Console.WriteLine("This number is odd");
        }

        public static void EqOrNot(int num1, int num2)
        {
            while (num1 == num2)
            {
                Console.WriteLine("these numbers are equal to eachother");
                break;
            }
            while (num1 != num2)
            {
                Console.WriteLine("these numbers are NOT equal to eachother");
                break;
            }
        }

        public static void PosOrNeg(int num1, int num2)
        {
            while (num1 > 0)
            {
                Console.WriteLine("The first number is positive");
                break;

            }

            while (num1 < 0)
            {
                Console.WriteLine("The first number is negative");
                break;
            }

            while (num2 > 0)
            {
                Console.WriteLine("The second number is positive");
                break;

            }
            while (num2 < 0)
            {
                Console.WriteLine("The second number is negative");
                break;
            }

        }

        public static void vote()
        {
            Console.Write("type your age here: ");
            int age = Convert.ToInt32(Console.ReadLine());

            while (age >= 18)
            {
                Console.WriteLine("congratulations! you are eligable to vote");
                break;
            }
            while (age < 18)
            {
                Console.WriteLine("Sorry, you are not eligable to vote");
                break;
            }
        }
        public static void range(int numPicked)
        {
            while (numPicked < -10 && numPicked > 10)
            {
                Console.WriteLine("this number is not in the range of -10 - 10");
            }
            while (numPicked > -10 && numPicked < 10)
            {
                Console.WriteLine("this number is in the range of -10 - 10");
                break;
            }
        }
        public static void mult(int numPicked)
        {
            for (int i = 1; i <= 12; i++)
            {
                int answer = i * numPicked;
                Console.WriteLine($"{i} X {numPicked} = {answer}");
            }
        }

    }
}
