using System;
using System.Collections.Generic;
using System.Text;

namespace RouteManagement
{
    public class Route
    {
        List<Point> points = new List<Point>();
        public void AddPoint(Point point)
        {
            points.Add(point);
        }

        public double GetLength()
        {
            double length = 0.0;
            for (int idx = 0; idx < points.Count - 1; idx++)
            {
                length += points[idx].GetDistance(points[idx + 1]);
            }
            return length;
        }
    }
}
