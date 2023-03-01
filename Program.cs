using System.Reflection.PortableExecutable;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           double h = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                    if(h >=10 && h <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Tuesday":
                    if (h >= 10 && h <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Wensday":
                    if (h >= 10 && h <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Thursday":
                    if (h >= 10 && h <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Friday":
                    if (h >= 10 && h <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Saturday":
                    if (h >= 10 && h <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Sunday":
                      Console.WriteLine("closed");
                    break;
            }
        }
    }
}