using NUnit.Framework;

namespace RouteManagement.Test
{
    public class PointTest
    {
        [Test, Sequential]
        public void TestDistance(
            [Values(0, 1, 0)] double x,
            [Values(0, 0, 1)] double y,
            [Values(0, 1, 1)] double expectedDistance
            )
        {
            Point referencePoint = new Point(0, 0);
            Point otherPoint = new Point(x, y);
            Assert.AreEqual(
                expectedDistance,
                referencePoint.GetDistance(otherPoint),
                1e-4);
        }
    }
}