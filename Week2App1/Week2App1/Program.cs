﻿namespace Week2App1
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

            while (secondNumber == 0)
            {
                Console.WriteLine("Write again connot be divided by 0");
                secondNumber = float.Parse(Console.ReadLine());

            }

            float resultSum = firstNumber + secondNumber;

            Console.WriteLine("Addition result: "+resultSum);

            float resultMinus = firstNumber - secondNumber;

            Console.WriteLine("Minus result: "+resultMinus);

            float resultMultipl = firstNumber * secondNumber;

            Console.WriteLine("Multipl result: " + resultMultipl);

            
            float resultDivide = firstNumber / secondNumber;
            Console.WriteLine("Divide result: " + resultDivide);

            float bigResult=0;

            if (resultSum > bigResult)
            {
                bigResult= resultSum;
            }
            if(resultMinus > bigResult)
            {
                bigResult= resultMinus;
            }
            if(resultMultipl > bigResult)
            {
                bigResult= resultMultipl;
            }
            if(resultDivide > bigResult)
            {
                bigResult= resultDivide;
            }
            
            Console.WriteLine("Biggest result: " + bigResult);
        }
    }
}