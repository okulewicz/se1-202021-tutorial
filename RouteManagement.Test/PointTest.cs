using NUnit.Framework;

namespace RouteManagement.Test
{
    public class PointTest
    {
        [Test]
        public void TestDistance()
        {
            Point referencePoint = new Point(0, 0);
            double expectedDistanceToSelf = 0.0;
            Assert.AreEqual(
                expectedDistanceToSelf,
                referencePoint.GetDistance(referencePoint),
                1e-4);
            Point horizontalPoint = new Point(1, 0);
            Point verticalPoint = new Point(0, 1);
            double expectedHorizontalDistance = 1.0;
            double expectedVerticalDistance = 1.0;
            Assert.AreEqual(
                expectedHorizontalDistance,
                referencePoint.GetDistance(horizontalPoint),
                1e-4);
            Assert.AreEqual(
                expectedVerticalDistance,
                referencePoint.GetDistance(verticalPoint),
                1e-4);


        }
    }
}