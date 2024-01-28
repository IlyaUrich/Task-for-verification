using System.Drawing;

namespace ConsoleApp4
{
    public struct Point 
    {
        public int X {  get; set; }
        public int Y { get; set; }


    }
    public class Coordinates
    {
        
        public static void Main(string[] args)
        {
            var array = new Point[4];

            for (int i = 0; i < 4;)
            {
                Console.WriteLine($"введите координаты {i + 1} вершины через запятую: ");
                string rawCords = Console.ReadLine() ?? string.Empty;

                var coords = rawCords.Split(",", StringSplitOptions.TrimEntries);
                if (coords.Length != 2)
                {
                    Console.WriteLine("Некорректно введены координаты точки, попробуйте снова");
                    continue;
                }
                Point point = new();

                point.X = int.Parse(coords[0]);
                point.Y = int.Parse(coords[1]);

                array[i] = point;
                
               i++;
            }
            int minCoordX=0;
            int minCoordY=0;
            int maxCoordX=0;
            int maxCoordY=0;
            for (int i = 0;i < array.Length;i++) 
            {
                if (array[i].X < minCoordX) 
                {
                    minCoordX = array[i].X;
                }
                if (array[i].Y < minCoordY) 
                {
                    minCoordY = array[i].Y;
                }
                if (array[i].X > maxCoordX) 
                {
                    maxCoordX = array[i].X;
                }
                if (array[i].Y > maxCoordY) 
                {
                    maxCoordY = array[i].Y;
                }
            }


            while (true)
            {
                Console.WriteLine("Введите через запятую координаты плоскости для проверки: ");

                string checkCords = Console.ReadLine() ?? string.Empty;
                var coords2 = checkCords.Split(",", StringSplitOptions.TrimEntries);
                if (coords2.Length != 2)
                {
                    Console.WriteLine("Некорректно введены координаты точки, попробуйте снова");
                    continue;
                }
                int X = int.Parse(coords2[0]);
                int Y = int.Parse(coords2[1]);

                if  (X >= minCoordX && X <= maxCoordX && Y >= minCoordY && Y <= maxCoordY) 
                {
                    Console.WriteLine(" Координаты проверяемой точки находится в пределах заданной координатной плоскости ");
                } else 
                {
                    Console.WriteLine("Координаты проверяемой точки НЕ находится в пределах заданной координатной плоскости");
                }

            }
           
        }
    }
}