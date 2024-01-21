namespace Week2App1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float firstNumber;
            float secondNumber;

            Console.WriteLine("Please enter first Number");
            firstNumber= float.Parse( Console.ReadLine());

            Console.WriteLine("Please enter second Number");
            secondNumber = float.Parse(Console.ReadLine());

            float resultSum = firstNumber + secondNumber;

            Console.WriteLine("Addition result: "+resultSum);

            float resultMinus = firstNumber - secondNumber;

            Console.WriteLine("Minus result: "+resultMinus);

            float resultMultipl = firstNumber * secondNumber;

            Console.WriteLine("Multipl result: " + resultMultipl);

            float resultDivide = firstNumber / secondNumber;
            Console.WriteLine("Divide result: " + resultDivide);

        }
    }
}