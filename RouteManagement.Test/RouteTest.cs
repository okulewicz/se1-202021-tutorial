using NUnit.Framework;

namespace RouteManagement.Test
{
    public class RouteTest
    {
        [Test]
        public void TestLength()
        {
            Route route = new Route();
            Assert.AreEqual(0.0, route.GetLength(), 1e-4);
            Point p1 = new Point(0, 0);
            route.AddPoint(p1);
            Assert.AreEqual(0.0, route.GetLength(), 1e-4);
            Point p2 = new Point(0, 1);
            route.AddPoint(p2);
            Assert.AreEqual(1.0, route.GetLength(), 1e-4);
            Point p3 = new Point(1, 1);
            route.AddPoint(p3);
            Assert.AreEqual(2.0, route.GetLength(), 1e-4);
        }
    }
}