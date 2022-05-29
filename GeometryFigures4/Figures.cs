// Zaripov Riyaz 220th group, 30.05.22 Figures-4

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Drawing;

namespace GeometryFigures4
{
    public static class Figures
    {
        static List<Figure> listOfFigures = new List<Figure>();

        public static void Add(Figure figure)
        {
            listOfFigures.Add(figure);
        }

        public static void Clear()
        {
            listOfFigures.Clear();
        }

        public static void Save(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, listOfFigures);
            }
        }

        public static void Load(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                listOfFigures = (List<Figure>)binaryFormatter.Deserialize(fileStream);
            }
        }
        public static void Draw(Graphics paper)
        {
            foreach(var fig in listOfFigures)
            {
                fig.Draw(paper, fig.colorOfPen, fig.thicknessOfPen);
            }
        }

        public static string Print()
        {
            string result = "";

            foreach (var figure in listOfFigures)
            {
                result += $"{figure.ToString() + Environment.NewLine}";
            }

            return result;
        }

        public static Figure LastFigure()
        {
            return listOfFigures.Last();
        }
    }
}
