using System;


using static System.Console;
namespace Pets
{
    public class Program
    {
        static void Main(string[] args)
        {

            Title = "====Virtual Pet App ====";
            WriteLine(@"  ____        _             _                  
 |  _ \  ___ | |_  ___     / \    _ __   _ __  
 | |_) |/ _ \| __|/ __|   / _ \  | '_ \ | '_ \ 
 |  __/|  __/| |_ \__ \  / ___ \ | |_) || |_) |
 |_|    \___| \__||___/ /_/   \_\| .__/ | .__/ 
                                 |_|    |_|    
");
            WriteLine("Welcome to the Pet App!");
            WriteLine("");


            Pet leoTheCat = new Pet();
            leoTheCat.FullName = "Leo";

            WriteLine("> Pet 1");
            WriteLine($"My Name is {leoTheCat.FullName}.");
            WriteLine("");

             Pet juniorTheParrot = new Pet();
            juniorTheParrot.FullName = "Junior";

            WriteLine(">Pet 2");
            WriteLine($"My name is {juniorTheParrot.FullName}.");
            WriteLine("");

            WriteLine("Press Any Key to Exit");
            ReadKey();

        }
    }
}
