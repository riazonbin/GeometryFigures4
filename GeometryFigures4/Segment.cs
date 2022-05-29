// Zaripov Riyaz 220th group, 24.05.22 Figures-3

using System;
using System.Drawing;

namespace GeometryFigures4
{
    [Serializable]
    public class Segment : Figure
    {
        public Point point2;

        public Segment(Point point1, Point point2) : base(point1)
        {
            this.point2 = point2;
        }

        public override void Draw(Graphics paper, Color colorOfPen, int thicknessOfPen)
        {
            var pen = new Pen(colorOfPen, thicknessOfPen);
            this.colorOfPen = colorOfPen;
            this.thicknessOfPen = thicknessOfPen;

            paper.DrawLine(pen, startingPoint.X, startingPoint.Y, point2.X, point2.Y);
        }

        public override string ToString()
        {
            return $"Segment A {startingPoint} - B {point2}";
        }
    }
}