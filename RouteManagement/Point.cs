using System;

namespace RouteManagement
{
    public class Point
    {
        private readonly double _x;
        private readonly double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double GetDistance(Point otherPoint)
        {
            return Math.Sqrt(
                (this._x - otherPoint._x) * (this._x - otherPoint._x) +
                (this._y - otherPoint._y) * (this._y - otherPoint._y));
        }
    }
}
