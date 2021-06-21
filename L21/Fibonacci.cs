namespace L21
{
    public class Fibonacci
    {
        static int num1 = 1;
        static int num2 = 1;
        public static int Iteration(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void Init()
        {
            num1 = Iteration(num1, num2);
            num2 = Iteration(num1, num2);
            System.Console.WriteLine(num1);
            System.Console.WriteLine(num2);
        }
    }
}