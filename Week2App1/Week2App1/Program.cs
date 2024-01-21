namespace Week2App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstNumber;
            float secondNumber;

            Console.WriteLine("Please enter first Number");
            firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second Number");
            secondNumber = float.Parse(Console.ReadLine());

            float resultSum = firstNumber + secondNumber;
            Console.WriteLine("Addition result: " + resultSum);

            float resultMinus = firstNumber - secondNumber;
            Console.WriteLine("Minus result: " + resultMinus);

            float resultMultiple = firstNumber * secondNumber;
            Console.WriteLine("Multiple result: " + resultMultiple);

            float resultDivide = firstNumber / secondNumber;
            Console.WriteLine("Divide result: " + resultDivide);

            Console.WriteLine("Avarage of the two: " + resultSum / 2);

            string bigResultName;
            float bigResult;
            if (resultSum > resultMinus)
            {
                bigResult = resultSum;
                bigResultName = "Result of sum";
            }
            else
            {
                bigResult = resultMinus;
                bigResultName = "Result of minus";
            }
            if (bigResult < resultDivide)
            {
                bigResult = resultDivide;
                bigResultName = "Result of divide";
            }
            if (bigResult < resultMultiple)
            {
                bigResult = resultMultiple;
                bigResultName = "Result of multiple";
            }
            Console.WriteLine("The biggest result: " + bigResultName + " with " + bigResult);
        }

    }
}
