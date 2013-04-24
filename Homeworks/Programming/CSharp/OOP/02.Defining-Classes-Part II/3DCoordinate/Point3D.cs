using System;
using System.Text;

public struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    private static readonly Point3D startPoint;

    public static int pointCount;
 
    //constructor
    public Point3D(int X, int Y, int Z):this()
    {
        this.X = X;
        this.Y = Y;
        this.Z = Z;
        Point3D.pointCount += 1;
    }
    static Point3D()
    {
        startPoint = new Point3D(0, 0, 0);
    }

    //prop
    public static Point3D StartPoint
    {
        get
        {
            return startPoint;
        }
    }

    //method
    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.AppendFormat("Point X: {0}", this.X.ToString());
        text.AppendLine();
        text.AppendFormat("Point Y: {0}", this.Y.ToString());
        text.AppendLine();
        text.AppendFormat("Point Z: {0}", this.Z.ToString());
        return text.ToString();
    }

}