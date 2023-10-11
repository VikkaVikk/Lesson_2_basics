using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_2_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In this program, there should be the ability to change the values of several variables in order to personalize the data output for a specific user.

            //To do this, you need to:

            //1. Create several variables of different types to store data, including:

            //Name
            //Age
            //Height
            //Scores in three subjects: History, Mathematics, and arts
            String name = "Viktorija";
            int age = 22;
            double height = 160.8;
            short history = 90;
            short mathematics = 50;
            short arts = 77;

            //2. Implement automatic calculation of the average score in the three subjects mentioned in point 1.
            double average = (history + mathematics + arts)/3.0;
            //3. Implement the ability to print information on the console using:
            //Standard output
            Console.WriteLine("Standart output:\nName: " + name + "\nAge: " + age + "\nHeight: " + height + "\nAverage score : " + average );
            //Formatted output
            Console.WriteLine("\nFormatted output:\nName: {0}\nAge:{1} \nHeight:{2} \nAverage score :{3}", name, age,height,average);
            //String interpolation
            Console.WriteLine($"\nString Interpolation output:\nName: {name}\nAge:{age} \nHeight:{height} \nAverage score :{average}");
            //4. All the code should be well-commented using both regular and XML comments.

            //**
            //5.As a bonus feature, the customer requests the ability to display data in the center of the console.
            Console.SetCursorPosition((Console.WindowWidth - "Centered Output".Length) / 2, Console.CursorTop);
            Console.WriteLine("Centered Output");


            Console.ReadKey();
        }
    }
}
