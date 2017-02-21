using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Point
    {

        double X { get; set; } //автоматически создали переменные, в которых будут храниться занчения
        double Y { get; set; }

        public Point(double x, double y) //создание конструктора для point 
        {
            X = x;
            Y = y;

        }

        class Edge //в классе edge мы задаем формулу для длины отрезка
        {
            Point A;
            Point B;
            double length;

            public Edge(Point pointA, Point pointB) //создание конструктора для edge 
            {
                A = pointA;
                B = pointB;
                EdgeLenght();
            }

            public double EdgeLenght() //Считаем длину отрезка
            {
                return lenght = Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2)); // формула
            }

            public double Lenght
            {
                get
                {
                    return lenght;
                }

            }
            class Triangle
            {
                Edge s1;
                Edge s2;
                Edge s3;
                double area;
                double Perimeter;
                double totalarea = 0, totalperimeter = 0, averagearea = 0, averageperimeter = 0;//итоговые значения площади, периметра и средние значения
                int areacount = 0;
                int perimetercount = 0;

                public Triangle(Point pointA, Point pointB, Point pointC) //задали треугольник, где s1 это точка с двумя координатами
                {

                    s1 = new Edge(pointA, pointB);
                    s2 = new Edge(pointA, pointC);
                    s3 = new Edge(pointB, pointC);

                    PerimeterT();
                    Area();
                    Isosceles();
                    Right();
                }


                public void PerimeterT()//нахождение периметра
                {
                    perimeter = s1.Lenght + s2.Lenght + s3.Lenght; //длина отрезка s1s2+ s1s3 +s2s3
                }

                public double Perimeter
                {
                    get
                    {
                        return perimeter;
                    }
                }


                public void Area()//формула площади через полупериметр(формула Герона)
                {
                    double semiperimeter = perimeter / 2;//находим полупериметр
                    areat = Math.Sqrt(semiperimeter * (semiperimeter - s1.Lenght) * (semiperimeter - s2.Lenght) * (semiperimeter * s3.Lenght));

                }

                public double AreaT
                {
                    get
                    {
                        return areat;
                    }
                }

                public bool Isosceles() //проверка треугольника на равнобедренность
                {

                    if ((s1.Lenght == s2.Lenght) || (s1.Lenght == s3.Lenght) || (s2.Lenght == s3.Lenght))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                public bool Right() //проверка треугольника на прямоугольность
                {

                    if ((s1.Lenght * s1.Lenght + s2.Lenght * s2.Lenght == s3.Lenght * s3.Lenght) || (s1.Lenght * s1.Lenght + s3.Lenght * s3.Lenght == s2.Lenght * s2.Lenght) || (s3.Lenght * s3.Lenght + s2.Lenght * s2.Lenght == s1.Lenght * s1.Lenght))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                
                   
                
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Triangle[] triangle1 =new Triangle [5] ;
                Triangle[i] = new Triangle();
                for (int i = 0; i < triangle1[i].Length; i++)
                {
                    if (triangle1[i].Isosceles())
                    {
                        totalarea = totalarea + triangle1[i].Area;
                        areacount++; //считаем количество равнобедренных треугольников
                    }

                    if (triangle1[i].Right())
                    {
                        totalperimeter = totalperimeter + triangle1[i].Perimeter;
                        perimetercount++; //количество прямоугольных треугольников
                    }
                }

                averagearea = totalarea / areacount;
                Console.WriteLine("Средняя площадь равнобедренных треугольников: " + averagearea);

                averageperimeter = totalperimeter / perimetercount;
                Console.WriteLine("Средний периметр прямоугольных треугольников: " + averageperimeter);
            }
        }
    }
}
