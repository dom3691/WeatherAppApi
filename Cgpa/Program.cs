using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cgpa
{
    public class Program
    {
        static void Main(string[] args)
        {

            string firstCourse;
            string secondCourse;
            string thirdCourse;
            string fourthCourse;


            Console.Write("Insert First Course: ");
            while (true)
            {
                firstCourse = Console.ReadLine();
                if (firstCourse == "" || !Regex.IsMatch(firstCourse, @"^[a-zA-Z0-9]+$") || firstCourse.Length != 6)
                {
                    Console.WriteLine("Please Insert CoursCode of 6 Character and alphanumeric. Eg: Mat111");
                    continue;
                }
                break;
            }



            Console.Write("Insert Second Course: ");
            while (true)
            {
                secondCourse = Console.ReadLine();
                if (secondCourse == "" || !Regex.IsMatch(secondCourse, @"^[a-zA-Z0-9]+$") || secondCourse.Length != 6)
                {
                    Console.WriteLine("Please Insert CoursCode of 6 Character and alphanumeric. Eg: Mat111");
                    continue;
                }
                break;
            }





            Console.Write("Insert Third Course: ");
            while (true)
            {
                thirdCourse = Console.ReadLine();
                if (thirdCourse == "" || !Regex.IsMatch(thirdCourse, @"^[a-zA-Z0-9]+$") || thirdCourse.Length != 6)
                {
                    Console.WriteLine("Please Insert CoursCode of 6 Character and alphanumeric. Eg: Mat111");
                    continue;
                }
                break;
            }





            Console.Write("Insert Fourth Course: ");
            while (true)
            {
                fourthCourse = Console.ReadLine();
                if (fourthCourse == "" || !Regex.IsMatch(fourthCourse, @"^[a-zA-Z0-9]+$") || fourthCourse.Length != 6)
                {
                    Console.WriteLine("Please Insert CoursCode of 6 Character and alphanumeric. Eg: Mat111");
                    continue;
                }
                break;
            }

            Console.WriteLine("\n");

            int courseUnit1;
            int courseUnit2;
            int courseUnit3;
            int courseUnit4;

            Console.Write("Insert 1st Course Unit. (Eg. 1-4): ");



            while (true)
            {
                courseUnit1 = int.Parse(Console.ReadLine());
                if (courseUnit1 == 0 || courseUnit1 > 4 || Regex.IsMatch(courseUnit1.ToString(), "^[A-Za-z!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?\\s]+$\r\n"))
                {
                    Console.WriteLine("Please Insert the correct format");
                    continue;
                }
                break;

            }


            while (true)
            {
                courseUnit2 = int.Parse(Console.ReadLine());
                if (courseUnit2 == 0 || Regex.IsMatch(courseUnit2.ToString(), "^[A-Za-z!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?\\s]+$\r\n"))
                {
                    Console.WriteLine("Please Insert the correct format");
                    continue;
                }
                break;
            }



            while (true)
            {

                courseUnit3 = int.Parse(Console.ReadLine());
                if (courseUnit3 == 0 || Regex.IsMatch(courseUnit3.ToString(), "^[A-Za-z!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?\\s]+$\r\n"))
                {
                    Console.WriteLine("Please Insert the correct format");
                    continue;
                }
                break;
            }



            while (true)
            {
                courseUnit4 = int.Parse(Console.ReadLine());
                if (courseUnit4 == 0 || Regex.IsMatch(courseUnit4.ToString(), "^[A-Za-z!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?\\s]+$\r\n"))
                {
                    Console.WriteLine("Please Insert the correct format");
                    continue;
                }
                break;
            }




        }
    }
}
