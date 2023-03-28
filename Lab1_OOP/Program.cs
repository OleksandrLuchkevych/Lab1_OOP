using System.Threading.Channels;

namespace Lab1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.Default;

            //Task 1
            Console.WriteLine("Task 1: ");
            Console.Write("Side of a sqare 'a' = ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Area of a square = {a * a} ");
            Console.WriteLine($"Perimeter of a square = {4 * a} ");
            Console.WriteLine();


            //Task 2
            Console.WriteLine("Task 2: ");
            string name;
            Console.WriteLine("What is your name ?");

            name = Console.ReadLine();

            Console.WriteLine($"How old are you {name} ?");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and your age is {age} ");
            Console.WriteLine();



            //Task 3
            Console.WriteLine("Task 3: ");
            Console.Write("Circle radius 'r' = ");

            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Circle length = {2 * Math.PI * r}");
            Console.WriteLine($"Area of circle = {Math.PI * r * r}");
            Console.WriteLine($"Сircle volume = {(4 * Math.PI * r * r * r) / 3}");


            Console.ReadKey ();
        }
    }
}