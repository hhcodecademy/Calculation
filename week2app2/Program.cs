namespace week2app2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day of the week:");
            int num;
            num=int.Parse(Console.ReadLine());
            if (num == 1) {
                Console.WriteLine("Studying Unuversity Lesson");
            }
            else if (num == 2)
            {
                Console.WriteLine("Studying Course Lesson");
            }
            else if (num == 3)
            {
                Console.WriteLine("Going to gym");
            }
            else if (num == 4)
            {
                Console.WriteLine("Hiking");
            }
            else if (num == 5)
            {
                Console.WriteLine("Studying Piano Lesson");
            }
            else if (num == 6)
            {
                Console.WriteLine("Code Academy first day");
            }
            else
            {
                Console.WriteLine("Code academy second day");
            }
        }
    }
}
