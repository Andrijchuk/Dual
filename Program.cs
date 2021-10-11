using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        static void Task1()
        {
            bool name = false;
            Console.WriteLine("Enter 3 float numbers: ");
            for (int i = 0; i < 3; i++)
            {
                float a = Convert.ToSingle(Console.ReadLine());
                if (a < 5.0 && a > -5.0)
                {
                    name = true;
                }
                else
                {
                    name = false;
                    break;
                }
            }
            string result = (name) ? "True!" : "False!";
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Task2()
        {
            Console.WriteLine("Enter 3 numbers: ");
            int one = Convert.ToInt32(Console.ReadLine());
            int count = 0, max = one, min = one;
            do
            {
                int twonumb = Convert.ToInt32(Console.ReadLine());
                if (min > twonumb)
                {
                    min = twonumb;
                }
                if (max < twonumb)
                {
                    max = twonumb;
                }
                count++;
            } while (count < 2);
            Console.WriteLine("Max: {0} \nMin: {1}", max, min);
            Console.ReadLine();
        }

        static void Task3()
        {
            int error = Convert.ToInt32(Console.ReadLine());
            string result = Enum.GetName(typeof(HTTPErrors), error);
            if (error < 400 || error > 411)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("HTTP Erorr name: {0}.", result);
            }
            Console.ReadLine();
        }
        static void Task4()
        {
            var dog = new Dog();
            dog.name = "Charlie";
            dog.mark = "Doberman";
            dog.age = 10;
            Console.WriteLine(dog);
            Console.ReadLine();
        }
    }
    public enum HTTPErrors
    {
        Error_Bad_Request = 400,
        Unauthorized = 401,
        Payment_Required = 402,
        Forbidden = 403,
        Not_Found = 404,
        Method_Not_Allowed = 405,
        Not_Acceptable = 406,
        Proxy_Authentication_Required = 407,
        Request_Timeout = 408,
        Conflict = 409,
        Gone = 410,
        Length_Required = 411,
    }
    public struct Dog
    {
        public string name;
        public string mark;
        public int age;
        public override string ToString() => $"({name},{mark},{age})";
    }
}
