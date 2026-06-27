using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}. What is your favorite color");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine("What about your favorite band?");
            string band = Console.ReadLine();
            
            Console.WriteLine($"A couple months back I met up with {name} at a {band} concert and saw the coolest shirt. {name} told me to look over where I saw someone with a {favColor} shirt that had a {animal} eating {food}. {name} couldn't believe it since that was their favorite animal and food so we had to ask the person where they got it from");
        }
        
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
       
        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        
        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        
        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            
            return sum;
        }
        static void Main(string[] args)
        {
            MadLib();
            Console.WriteLine(Add(40,29));
            Console.WriteLine(Subtract(75, 42));
            Console.WriteLine(Multiply(6,7));
            Console.WriteLine(Divide(500,25));
            Console.WriteLine(Sum(25,7,32,13,37,87,46,75));

        }
    }
}
