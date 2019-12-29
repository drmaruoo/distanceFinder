using distanceFinder;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace distanceFinderTests
{
    [TestClass]
    public class distanceFinderTest
    {
        [TestMethod]
        public void ValidVectorCreation()
        {
            float point1 = 1.5f;
            float point2 = 5.6f;
            Vector vector;
            Vector expectedVector = new Vector(1.5f, 5.6f);

            vector = new Vector(point1, point2);

            Assert.AreEqual(expectedVector.X, vector.X);
            Assert.AreEqual(expectedVector.Y, vector.Y);
        }

        [TestMethod]
        public void ValidDistanceMeasurment()
        {
            Vector vector1 = new Vector(0f, 0f);
            Vector vector2 = new Vector(3f, 3f);
            float expectedDistance = (float)(3 * Math.Sqrt(2));

            float distance = Vector.GetDistance(vector1, vector2);

            Assert.AreEqual(expectedDistance, distance, 0.01f);
        }
    }
}
