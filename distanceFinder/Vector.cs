using System;

namespace distanceFinder
{
    class Vector
    {
        public float X { get; set; }
        public float Y { get; set; }
        private static Random rng = new Random();

        public Vector(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static Vector GetRandomVector(int maxValue)
        {
            Vector vector = new Vector(rng.Next(maxValue), rng.Next(maxValue));
            return vector;
        }

        public static float GetDistance(Vector vector1, Vector vector2)
        {
            float distanceBetweenX = (float)vector2.X - vector1.X;
            float distanceBetweenY = (float)vector2.Y - vector1.Y;
            float distance = (float)Math.Sqrt(Math.Pow(distanceBetweenX, 2) + Math.Pow(distanceBetweenY, 2));
            return distance;
        }
        public override string ToString()
        {
            return String.Format("X = {0} | Y = {1}", X, Y);
        }
    }
}
