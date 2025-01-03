namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimalnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            
            Console.WriteLine($"One day, {userName} was walking through the woods while wearing a {favColor} t-shirt. {userName} saw a {favAnimalnimal} listening to {favBand}");
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

            foreach (int number in numbers)
            {
                //sum = sum + number;
                sum += number;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //Madlib();
            //Console.WriteLine(Add(numOne:2, numTwo:2))
            //int addedNums = Add(2, 2); 
            //Console.WriteLine(addedNums);
            //Console.WriteLine(Subtract(2, 2));
            //Console.WriteLine(Multiply(2, 2));
           //Console.WriteLine(Divide(2, 2));
           Console.WriteLine(Sum(5,5,5));
            
        }
    }
}
