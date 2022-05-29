// Zaripov Riyaz 220th group, 30.05.22 Figures-4

using System;
using System.Drawing;

namespace GeometryFigures4
{
    [Serializable]
    public class Triangle : Figure
    {
        public Point point2;
        public Point point3;

        public Triangle(Point point1, Point point2, Point point3) : base(point1)
        {
            this.point2 = point2;
            this.point3 = point3;
        }

        public override void Draw(Graphics paper, Color colorOfPen, int thicknessOfPen)
        {
            var pen = new Pen(colorOfPen, thicknessOfPen);
            this.colorOfPen = colorOfPen;
            this.thicknessOfPen = thicknessOfPen;

            paper.DrawLine(pen, startingPoint.X, startingPoint.Y, point2.X, point2.Y);
            paper.DrawLine(pen, startingPoint.X, startingPoint.Y, point3.X, point3.Y);
            paper.DrawLine(pen, point2.X, point2.Y, point3.X, point3.Y);
        }

        public override string ToString()
        {
            return $"Triangle A {startingPoint} - B {point2} - C {point3}";
        }
    }
}
