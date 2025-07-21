using System.Drawing;

namespace OOPAssignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project
            //Question1 =Creating the Class
            #region Question2
            //_3DPoint p= new _3DPoint(10,10,10);
            //Console.WriteLine(p.ToString());
            #endregion
            #region Question3
            #region question3
            //double[] firstPoint = new double[3];
            //double[] secondPoint = new double[3];
            //Console.WriteLine("First Point Coordinates");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter the Coordinates in the following sequence : Coordinate number {i + 1} ");
            //    double.TryParse(Console.ReadLine(), out firstPoint[i]);
            //}
            //Console.Clear();
            //Console.WriteLine("Second Point Coordinates");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter the Coordinates in the following sequence : Coordinate number {i + 1} ");
            //    double.TryParse(Console.ReadLine(), out secondPoint[i]);
            //}
            //Console.Clear();
            //// till here we can check the equality using the two arrays,but i know that we want to check them using the class it self
            //_3DPoint p1 = new _3DPoint(firstPoint[0], firstPoint[1], firstPoint[2]);
            //_3DPoint p2 = new _3DPoint(secondPoint[0], secondPoint[1], secondPoint[2]); 
            #endregion
            #region Question4
            /*Console.WriteLine(p1==p2);*/ // It does not work properly ,So it needs to be overloaded to make it work on the values not the reference
                                           // It work properly after the overloading
            #endregion
            #endregion
            //Question4 inside Question3
            #region Question5
            //Compare by X then by Y
            // _3DPoint[] points =
            //  {
            //     new _3DPoint(2,3,4),
            //     new _3DPoint(3,4,5),
            //     new _3DPoint(4,5,6),
            //     new _3DPoint(0,2,2),
            //     new _3DPoint(1,2,2),
            // };
            //Array.Sort(points);
            // foreach (var point in points)
            // {
            //     Console.WriteLine(point.ToString());
            // }
            /*Method	Purpose
                  CompareTo()	Defines how to compare 2 objects
                  Array.Sort()	Sorts using CompareTo() under the hood*/
            #endregion
            #region Question6
            //_3DPoint point1 = new _3DPoint() { X=3,Y=8,Z=9};
            //_3DPoint point2 = new _3DPoint();
            //point2 = (_3DPoint)point1.Clone();
            //Console.WriteLine(point2.ToString());

            //Another way using copy constructor
            //_3DPoint point1 = new _3DPoint() { X = 3, Y = 8, Z = 9 };
            //_3DPoint point2 = new _3DPoint(point1);
            //Console.WriteLine(point2.ToString());



            #endregion
            #endregion
            #region Second Project
            //The main idea is to define them static members so we can call them without creating any object

            //  double x = 8;
            //  double y = 9;
            //  double devideResult = MathBasicOperation.Divide(y, x);
            //  double subResult = MathBasicOperation.Sub(y, x);
            // double sumResult= MathBasicOperation.Sum(y, x);
            //double mulResult=  MathBasicOperation.Multiply(y, x);
            //  Console.WriteLine($"Devide= {devideResult} \n sum = {sumResult} \n sub ={subResult} \n Multiply ={mulResult}");



            #endregion
            #region Third Project
            #region  Q1:Q3
            //TimeDetails td1 = new TimeDetails(1, 10, 3);
            //Console.WriteLine(td1.ToString());

            //TimeDetails td2 = new TimeDetails(3600);
            //Console.WriteLine(td2.ToString());

            //TimeDetails td3 = new TimeDetails(7800);
            //Console.WriteLine(td3.ToString());

            //TimeDetails td4 = new TimeDetails(666);
            //Console.WriteLine(td4.ToString()); 
            #endregion
            #region Question4
            TimeDetails td1=new TimeDetails(1,4,55);
            TimeDetails td2=new TimeDetails(2,4,1);
            TimeDetails td3 = new TimeDetails();
            TimeDetails td4 = default;
            //TimeDetails td3=td1 + td2;
            //Console.WriteLine(td3.ToString());

            //td3 = td1 + 7800;
            //Console.WriteLine(td3.ToString());

            //td3 = td3 + 666;
            //Console.WriteLine(td3.ToString());

            //td3 = td1 - td2;
            //Console.WriteLine(td3.ToString());

            //Console.WriteLine(++td1);

            //Console.WriteLine(--td4);

            //if(td1<td2)
            //    Console.WriteLine("td1<td");
            //else if(td1>td2)
            //    Console.WriteLine("td1>td2");
            //else 
            //    Console.WriteLine("td1=td2");

            //  Console.WriteLine(td1>td4);

            //Console.WriteLine(td1>=td2);
            //Console.WriteLine(td2>=td3);
            //Console.WriteLine(td3>=td4);
            //Console.WriteLine(td4>=td1);
            //Console.WriteLine(td4>=td2);




            #endregion



            #endregion
        }
    }
}
