using System;

namespace distanceFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = Vector.GetRandomVector(10);
            Vector vector2 = Vector.GetRandomVector(10);
            Console.WriteLine("For randomly generated points: ");
            Console.WriteLine(vector1.ToString() + " and " + vector2.ToString());
            Console.WriteLine("The distance is: " + Vector.GetDistance(vector1, vector2));
            Console.ReadLine();
        }
    }
}
