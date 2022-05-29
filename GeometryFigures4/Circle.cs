// Zaripov Riyaz 220th group, 30.05.22 Figures-4

using System;
using System.Drawing;

namespace GeometryFigures4
{
    [Serializable]
    public class Circle : Figure
    {
        public int Width;
        public int Height;

        public Circle(Point point, int width, int height) : base(point)
        {
            this.Width = width;
            this.Height = height;
        }

        public override void Draw(Graphics paper, Color colorOfPen, int thicknessOfPen)
        {
            var pen = new Pen(colorOfPen, thicknessOfPen);
            this.colorOfPen = colorOfPen;
            this.thicknessOfPen = thicknessOfPen;

            paper.DrawEllipse(pen, startingPoint.X, startingPoint.Y, Width, Height);
        }

        public override string ToString()
        {
            return $"Circle at {startingPoint}, Width: {Width}, Height {Height}";
        }

    }
}
