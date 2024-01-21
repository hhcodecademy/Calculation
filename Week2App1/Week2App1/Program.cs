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

            //rustem
            float resultSum = firstNumber + secondNumber;

            Console.WriteLine("Addition result: "+resultSum);

            //narmin
            float resultMinus = firstNumber - secondNumber;

            Console.WriteLine("Minus result: "+resultMinus);

            //nicat
            float resultMultipl = firstNumber * secondNumber;

            Console.WriteLine("Multipl result: " + resultMultipl);

            //fuzuli
            float resultDivide = firstNumber / secondNumber;
            Console.WriteLine("Divide result: " + resultDivide);

            //float bigResult;
            //if (resultSum > resultMinus)
            //{
            //    bigResult = resultSum;
            //}
            //else {

            //    bigResult = resultMinus;
            //}

            //if (bigResult > resultMultipl)
            //{
            //    bigResult = bigResult;
            //}
            //else {
            //    bigResult = resultMultipl;
            //}

            // if (bigResult > resultDivide)
            //{
            //    bigResult = bigResult;
            //}
            //else
            //{
            //    bigResult = resultDivide;
            //}
            if (resultSum > resultMinus)
            {
                Console.WriteLine("birinci masadan sum secildi");
            }
            else
            {
                Console.WriteLine("birinci masdan MINUS secildi");
            }
            if(resultMultipl > resultDivide)
            {
                Console.WriteLine("ikinci masadan MULTIPI secildi");
            }
            else
            {
                Console.WriteLine("ikinci masadan DIVIDE secildi");
            }
        }
    }
}