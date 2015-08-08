using System;
using System.Collections.Generic;

namespace CohesionAndCoupling
{
    static class Utils
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return "";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }

        public static double CalcDistance(params double[] points)
        {
            if (points.Length % 2 != 0)
            {
                throw new ArgumentException("Invalid arguments! Both objects must be determined by equal number of points!");
            }

            int numberOfPoints = points.Length / 2;

            var distancesBetweenPoints = new double[numberOfPoints];

            for (int i = 0; i < numberOfPoints; i++)
            {
                var pointObjectTwo = points[numberOfPoints + i];
                var pointObjectOne = points[i];

                distancesBetweenPoints[i] = (pointObjectTwo - pointObjectOne) * (pointObjectTwo - pointObjectOne);
            }

            double sum = 0;
            for (int i = 0; i < distancesBetweenPoints.Length; i++)
            {
                sum += distancesBetweenPoints[i];
            }

            double distance = Math.Sqrt(sum);  
            return distance;
        }

        public static double CalcDiagonal(params double[] sides)
        {
            var parametersToPass = new List<double>();

            for (int i = 0; i < sides.Length; i++)
            {
                parametersToPass.Insert(0, 0);
                parametersToPass.Add(sides[i]);
            }

            double distance = CalcDistance(parametersToPass.ToArray());
            return distance;
        }

        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }
        
        public static double CalcDiagonalXYZ()
        {
            double distance = CalcDistance(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public static double CalcDiagonalXY()
        {
            double distance = CalcDistance(0, 0, Width, Height);
            return distance;
        }

        public static double CalcDiagonalXZ()
        {
            double distance = CalcDistance(0, 0, Width, Depth);
            return distance;
        }

        public static double CalcDiagonalYZ()
        {
            double distance = CalcDistance(0, 0, Height, Depth);
            return distance;
        }
        
    }
}