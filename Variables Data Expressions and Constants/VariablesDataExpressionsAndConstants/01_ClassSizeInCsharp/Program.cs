/*Task 1. Class Size in C#

    Refactor the following code to use proper variable naming and simplified expressions:
 * 
   public class Size
{
    public double wIdTh, Viso4ina;
    public Size(double w, double h)
    {
        this.wIdTh = w;
        this.Viso4ina = h;
    }

    public static Size GetRotatedSize(
        Size s, double angleOfTheFigureThatWillBeRotaed)
    {
        return new Size(
            Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
                Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina,
            Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
                Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina);
    }
}
*/


using System;
public class Size
{
    private double width;
    private double height;
    public Size(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public static Size GetRotatedSize(Size size, double angleRotation)
    {
        double width = Math.Abs(Math.Cos(angleRotation)) * size.width +
                Math.Abs(Math.Sin(angleRotation)) * size.height;
        
        double height = Math.Abs(Math.Sin(angleRotation)) * size.width +
                Math.Abs(Math.Cos(angleRotation)) * size.height;

        return new Size(width, height);
    }
}