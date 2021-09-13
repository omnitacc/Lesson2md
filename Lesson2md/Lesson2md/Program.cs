using System;

namespace Lesson2md
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/
            Console.WriteLine("Kā tevi sauc?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Sveiks {userName}");
            Console.WriteLine("----------------------------------------------?");
            Console.WriteLine("");

            Console.WriteLine("Kāds ir tavs vecums?");
            string userAgeText = Console.ReadLine();
            int userAge = int.Parse(userAgeText);
            int userAgeNext = userAge + 1;
            bool isAdult = userAge >= 18;
            Console.WriteLine($"Nākamgad tev paliks {userAgeNext}, Tu esi pilngadīgs: {isAdult}");
            Console.WriteLine("----------------------------------------------?");
            Console.WriteLine("");

            Console.WriteLine("Ievadiet 3 skaitļus lai uzzinātu lielāko un mazāko no tiem:");
            Console.WriteLine("Ievadiet pirmo:");
            string userNumber1Text = Console.ReadLine();
            int userNumber1 = int.Parse(userNumber1Text);
            Console.WriteLine("Ievadiet otro:");
            string userNumber2Text = Console.ReadLine();
            int userNumber2 = int.Parse(userNumber2Text);
            Console.WriteLine("Ievadiet trešo:");
            string userNumber3Text = Console.ReadLine();
            int userNumber3 = int.Parse(userNumber3Text);
            int maxNumber = Math.Max(userNumber1, userNumber2);
            int maxNumber2 = Math.Max(maxNumber, userNumber3);
            Console.WriteLine("Liekākais ir: {0}", maxNumber2);
            Console.WriteLine("----------------------------------------------?");
            Console.WriteLine("");

            int minNumber = Math.Min(userNumber1, userNumber2);
            int minNumber2 = Math.Min(minNumber, userNumber3);
            Console.WriteLine("Mazākais ir: {0}", minNumber2);
            Console.WriteLine("----------------------------------------------?");
            Console.WriteLine("");

            Console.WriteLine("Ievadiet 2 skaitļus lai uzzinātu to dalijuma atlikumu:");
            Console.WriteLine("Ievadiet pirmo:");
            string userNumber4Text = Console.ReadLine();
            int userNumber4 = int.Parse(userNumber4Text);
            Console.WriteLine("Ievadiet otro:");
            string userNumber5Text = Console.ReadLine();
            int userNumber5 = int.Parse(userNumber5Text);
            int minNumberMod = Math.Min(userNumber4, userNumber5);
            int maxNumberMod = Math.Max(userNumber4, userNumber5);
            int mod = maxNumberMod % minNumberMod;
            Console.WriteLine("Atlikums: {0}", mod);
            Console.WriteLine("----------------------------------------------?");
            Console.WriteLine("");

            Console.WriteLine("Ievadiet skaitli lai uzzinātu tā paritāti:");
            string userNumber6Text = Console.ReadLine();
            int userNumber6 = int.Parse(userNumber6Text);
            int modTest = userNumber6 % 2;
            bool oddOrEven = modTest == 0;
            Console.WriteLine("Ievadīto skaitļu paritāte ir: {0}", oddOrEven);
            Console.WriteLine("----------------------------------------------?");
            Console.WriteLine("");

            Console.WriteLine("Ievadiet 2 skaitļus lai uzzinātu taisnstūra laikumu ko viedotu šāda garuma malas:");
            Console.WriteLine("Ievadiet pirmo:");
            string rectangleSide1Text = Console.ReadLine();
            int rectangleSide1 = int.Parse(rectangleSide1Text);
            Console.WriteLine("Ievadiet otro:");
            string rectangleSide2Text = Console.ReadLine();
            int rectangleSide2 = int.Parse(rectangleSide2Text);
            int rectangleArea = rectangleSide1 * rectangleSide2;
            Console.WriteLine("Taisnstūra laukums ir: {0}", rectangleArea);
            Console.WriteLine("----------------------------------------------?");
            Console.WriteLine("");

            //tā kā uzdevumā nebija minēts vienadsanu trijstūra paveids vaicāju lietotājam arī leņķi...
            Console.WriteLine("Ievadiet skaitli kas apzīmēs vienadsānu trijstūra malu garumus un leņkištarp šim malām lai uzzinātu šī trijstūra laikumu:");
            Console.WriteLine("Ievadiet malas garumu");
            string triangleSideText = Console.ReadLine();
            int riangleSide = int.Parse(triangleSideText);
            Console.WriteLine("Ievadiet leņķi starp malām (grados):");
            string triangleAngleText = Console.ReadLine();
            int triangleAngle = int.Parse(triangleAngleText);
            double angle = Math.PI * triangleAngle / 180.0;
            double triangleArea = (((riangleSide * riangleSide)/2)*Math.Sin(angle));
            Console.WriteLine("trijstūra laikums ir: {0}", triangleArea);
            Console.WriteLine("----------------------------------------------?");
            Console.WriteLine("");

            string interpolatedText = $"Tātad jūsu vārds ir {userName}, un vecums ir {userAge} gadi?!";
            Console.WriteLine(interpolatedText);
        }
    }
}
