using System.Text;

namespace AnnouncmentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to us");

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Please enter your middle name: ");
            string middleName = Console.ReadLine();

            Console.WriteLine("Please enter gender: (Male/Female) ");
            string gender = Console.ReadLine();

            Console.WriteLine("Please enter date of birth (Year): ");
            int dateOfBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your official address: ");
            string address = Console.ReadLine();

            string genderDescription = String.Empty;

            if (gender.ToLower() == "male")
            {
                genderDescription = " oglu";
            }
            else if (gender.ToLower() == "female")
            {
                genderDescription = " qizi";
            }
            else
            {
                Console.WriteLine("Please enter correct information..");
                return;
            }
            // https://az.wikipedia.org/wiki/H%C9%99yat_d%C3%B6vr%C3%BC

            string lifePeriod = String.Empty;

            string registerToWork = " qeydə alınmamışdır";
            int age = DateTime.Now.Year - dateOfBirth;
            if (age > 65)
            {
                lifePeriod = "Qocaliq";
            }
            else if (age > 35)
            {
                lifePeriod = "orta yaş";
            }
            else if (age > 18)
            {
                lifePeriod = "gənclik";
                registerToWork = "qeydə alınmışdır";
            }
            else if (age > 16)
            {
                lifePeriod = "erkən gənclik";
            }
            else if (age > 11)
            {
                lifePeriod = "yeniyetməlik";
            }
            else
            {
                lifePeriod = "uşaqlıq";
            }

        

            string result = $" Siz {surname} {name} {middleName} {genderDescription} {dateOfBirth} doğulduğunuz üçün hal-hazırda {age}-ınız vardır. Azərbaycan qanunvericiliyinə"
                + $"uyğun olaraq {lifePeriod} dövrünüzü yaşamaqdasınız. Bu iş yerinə sadəcə gənclik dönəmində olan şəxslər müraciət edə bilərlər."
                + $"Bu tələbi nəzərə alaraq sizin müraciətiniz {registerToWork}";

            Console.WriteLine(result);

        }
    }
}