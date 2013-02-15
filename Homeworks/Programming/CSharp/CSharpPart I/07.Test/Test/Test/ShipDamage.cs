using System;

class ShipDamage
{
    static void Main()
    {

        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int cx1 = int.Parse(Console.ReadLine());
        int cy1 = int.Parse(Console.ReadLine());
        int cx2 = int.Parse(Console.ReadLine());
        int cy2 = int.Parse(Console.ReadLine());
        int cx3 = int.Parse(Console.ReadLine());
        int cy3 = int.Parse(Console.ReadLine());
        int damage = 0;

        int minX = Math.Min(sx1, sx2);
        int maxX = Math.Max(sx1, sx2);
        int minY = Math.Min(sy1, sy2);
        int maxY = Math.Max(sy1, sy2);
        sx1 = minX;
        sx2 = maxX;
        sy1 = minY;
        sy2 = maxY;

        cy1 = 2 * h - cy1;
        cy2 = 2 * h - cy2;
        cy3 = 2 * h - cy3;



        if (cx1 > sx1 && cx1 < sx2 && cy1 > sy1 && cy1 < sy2)
        {
            damage += 100;
        }
        if (cx2 > sx1 && cx2 < sx2 && cy2 > sy1 && cy2 < sy2)
        {
            damage += 100;
        }
        if (cx3 > sx1 && cx3 < sx2 && cy3 > sy1 && cy3 < sy2)
        {
            damage += 100;
        }
        if ((cx1 == sx1 || cx1 == sx2) && (cy1 == sy1 | cy1 == sy2))
        {
            damage += 25;
        }
        if ((cx2 == sx1 || cx2 == sx2) && (cy2 == sy1 || cy2 == sy2))
        {
            damage += 25;
        }
        if ((cx3 == sx1 || cx3 == sx2) && (cy3 == sy1 || cy3 == sy2))
        {
            damage += 25;
        }
        if ((cx1 == sx1 || cx1 == sx2) && (cy1 > sy1 && cy1 < sy2))
        {
            damage += 50;
        }
        if ((cx2 == sx1 || cx2 == sx2) && (cy2 > sy1 && cy2 < sy2))
        {
            damage += 50;
        }
        if ((cx3 == sx1 || cx3 == sx2) && (cy3 > sy1 && cy3 < sy2))
        {
            damage += 50;
        }
        if ((cy1 == sy1 || cy1 == sy2) && (cx1 > sx1 && cx1 < sx2))
        {
            damage += 50;
        }
        if ((cy2 == sy1 || cy2 == sy2) && (cx2 > sx1 && cx2 < sx2))
        {
            damage += 50;
        }
        if ((cy3 == sy1 || cy3 == sy2) && (cx3 > sx1 && cx3 < sx2))
        {
            damage += 50;
        }
        Console.WriteLine(damage + "%");
    }
}

