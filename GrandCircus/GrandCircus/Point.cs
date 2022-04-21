//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GrandCircus
//{
//    //EXERCISE 42

//    public class Point
//    {
//        //Inputs go here
//        public double X { get; set; }

//        public double Y { get; set; }

//        public double Z { get; set; }

//        //Constructor
//        public Point(int x, int y)
//        {

//            X = x;
//            Y = y;

//        }

//        //Method (for output)
//        public string FindCoordinates()
//        {

//            return $"You have created a point object ({X},{Y})";

//        }

//        //CalculateDistance Method

//        public double CalculateDistance()
//        {
//            double distance = Math.Sqrt(X * X + Y * Y);
//            return distance;
//        }


//        //Calculate Midpoint

//    //Constructor2
//    public Point(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }

//    public Point CalculateMidpoint(Point other)
//    {
//        //midpoint formula is (x1+x2)/2 , (y1 + y2)/2
//        double xMid = (other.X + this.X) / 2;
//        double yMid = (other.Y + this.Y) / 2;

//        return new Point(xMid, yMid);
//    }

//    public Point(double x, double y, double z)
//    {
//        X = x;
//        Y = y;
//        Z = z;
//    }


//    //parametereless constructor
//    public Point()
//    {

//    }
//    //}

//    public class Square
//    {
        
//            //Inputs go here
//            public int S { get; set; }
        

//        //Constructor
//        public Square(int s)
//        {
//            S = s;
//        }

//        public double CalculatePerimeter()
//        {
//            double perimeter = 4*S;
//            return perimeter;
//        }

//        public double CalculateArea()
//        {
//            double area = S * S;
//            return area;
//        }



//    }
//}
