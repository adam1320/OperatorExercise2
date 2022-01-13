using System;

namespace OperatorExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double answer=AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {answer}");


        }

        //Create method
        public static double AreaOfCircle(double radius)
        {
            double AreaOfCircle = Math.PI * radius * radius;
            return AreaOfCircle;
        }
        
        

    }
}
