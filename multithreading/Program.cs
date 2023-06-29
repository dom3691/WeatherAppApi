using System;
using System.IO;

namespace multithreading
{
    public class Program 
    {
        static void Main(string[] args)
        {
            // string file = @"C:\Users\James\Downloads\Video\WEEK 3 CLASS\text.txt";

            //string word = "this is the text";

            //File.WriteAllText(file, word);

            try
            {
                throw new Exception("This is an exception ");
            }
            catch (Exception tt)
            {

                Console.WriteLine(tt.Message);
            }


          
        }
    }
}
