// https://www.csharpstudy.com/CSharp/CSharp-conditional.aspx

using System;

namespace MySystem
{
    class Program
    {
        static bool verbose = false;
        static bool continueOnError = false;
        static bool logging = false;
        static int val;

        static void Main(string[] args)
        {            
            Test_if();
            int price = Test_Switch("사과");
            Console.WriteLine("Price: {0}", price);
            Example(args);
        }

        static void Test_if()
        {
            int a = -11;
            if (a>=0)
            {
                val = a;
            }
            else
            {
                val = -a;
            }

            // 출력값 : 11
            Console.WriteLine(val);
        }

        static int Test_Switch(string category)
        {
            int price;
            switch (category)
            {
            case "사과":
                price = 1000;
                break;
            case "딸기":
                price = 1100;
                break;
            case "포도":
                price = 900;
                break;
            default:
                price = 0;
                break;
            }
            return price;
        }
        static void Example(string[] args)
        {
            string option = args[0];
            switch (option.ToLower())
            {
                case "/v":
                case "/verbose":
                    verbose = true;       
                    break;
                case "/c":
                    continueOnError = true;
                    break;
                case "/l":
                    logging = true;
                    break;
                default:
                    Console.WriteLine("Unknown argument: {0}", option);
                    break;
            }            
        }
    }
}