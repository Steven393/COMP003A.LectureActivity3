/*
* Author: Steven Gonzalez
* Course: COMP-003A
* Purpose: Numeric to letter grade using an if-else statement and Integer to string day using an switch statement
*/

namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeric to letter grade using an if-else statement");

            Console.WriteLine("Enter a numeric grade (0-100): ");

            double inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber <= 100 && inputNumber >= 0)
            {
                if (inputNumber >= 0 && inputNumber <60)
                {
                    Console.WriteLine("Letter Grade: F");
                }
                else if (inputNumber >= 0 && inputNumber <70)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else if (inputNumber >= 70 && inputNumber <80)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (inputNumber >= 80 && inputNumber <90)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (inputNumber >= 90)
                {
                    Console.WriteLine("Letter Grade: A");
                }

                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
            Console.WriteLine("**********************************************");

            Console.WriteLine("Integer to string day using an switch statement");
            Console.WriteLine("Enter an integer day of the week (1-7): ");

            int NumericDay = Convert.ToInt32(Console.ReadLine());

            switch (NumericDay)
            {

                case 1:
                    Console.WriteLine("String Day: Monday");
                    break;
                case 2:
                    Console.WriteLine("String Day: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("String Day: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("String Day: Thursday");
                    break;
                case 5:
                    Console.WriteLine("String Day: Friday");
                    break;
                case 6:
                    Console.WriteLine("String Day: Saturday");
                    break;
                case 7:
                    Console.WriteLine("String Day: Sunday");
                    break;
                default:
                    Console.WriteLine(NumericDay > 7 ? "Invalid Day!" : "Invalid Day!");
                    break;
            }



        }
    }
}