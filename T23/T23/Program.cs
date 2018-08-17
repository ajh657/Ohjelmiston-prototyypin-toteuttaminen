using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T23
{
    class Program
    {

        static void Main(string[] args)
        {
            int Type;

            Welcome();

            while (true)
            {
                Type = AskForType();

                Console.WriteLine("");

                int number1 = Random(900);
                int number2 = Random(900);

                while (true)
                {
                    GenerateCauculation(Type, number1, number2);
                    int ResultI = GenerateCauculationResult(Type, number1, number2);

                    if (TestResult(AskForResult(), ResultI))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong. Please Try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                break;
            }

            Exit();

        }
        /// <summary>
        /// tests result
        /// </summary>
        /// <param name="UserResult"></param>
        /// <param name="CorrectResult"></param>
        /// <returns>Returns bool</returns>
        public static bool TestResult(int UserResult, int CorrectResult)
        {
            bool Result = false;

            if (UserResult == CorrectResult) Result = true;

            return Result;
        }
        /// <summary>
        /// Prints correct cauculation
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        public static void GenerateCauculation(int Type, int number1, int number2)
        {

            switch (Type)
            {
                case 1:
                    Console.WriteLine(number1 + " + " + number2 + " = " + " ?");
                    break;

                case 2:
                    Console.WriteLine(number1 + " - " + number2 + " = " + " ?");
                    break;

                case 3:
                    Console.WriteLine(number1 + " * " + number2 + " = " + " ?");
                    break;

                case 4:
                    Console.WriteLine(number1 + " / " + number2 + " = " + " ?");
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// generates correct cauculation
        /// </summary>
        /// <param name="Type">cauculation type</param>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>retruns cauculation</returns>
        public static int GenerateCauculationResult(int Type, int number1, int number2)
        {
            int Return = 0;

            switch (Type)
            {
                case 1:
                    Return = number1 + number2;
                    break;

                case 2:
                    Return = number1 - number2;
                    break;

                case 3:
                    Return = number1 * number2;
                    break;

                case 4:
                    Return = number1 / number2;
                    break;

                default:
                    break;
            }

            return Return;
        }
        /// <summary>
        /// asks for cauculation type
        /// </summary>
        /// <returns>Returns type</returns>
        public static int AskForType()
        {
            int result;
            while (true)
            {
                Console.WriteLine("Please input number");
                Console.WriteLine("1 = +");
                Console.WriteLine("2 = -");
                Console.WriteLine("3 = *");
                Console.WriteLine("4 = /");
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result < 5 && result > 0) break;
                }
            }
            Console.Clear();
            return result;
        }
        /// <summary>
        /// generates random values
        /// </summary>
        /// <param name="Max">Max Value for random</param>
        /// <returns>Random Value</returns>
        public static int Random (int Max)
        {
            Max++;

            Random rnd = new Random();

            return rnd.Next(0, Max);
        }
        /// <summary>
        /// asks for correct result from user
        /// </summary>
        /// <returns>Returns users input</returns>
        public static int AskForResult()
        {

            int Return = 0;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out Return)) break;
            }

            return Return;
        }


        /// <summary>
        /// exits program on key press
        /// </summary>
        static void Exit()
        {
            Console.WriteLine("");
            Console.WriteLine("Correct");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        /// <summary>
        /// Welcomes the user
        /// </summary>
        static void Welcome()
        {
            Console.WriteLine("Welcome to atrimetiikka");
            Console.WriteLine();
            Console.WriteLine("Please coore one number");
            Console.WriteLine();
        }
    }
}
