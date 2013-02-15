using System;

class FighterAttack
{
    static void Main()
    {
        int pX1 = int.Parse(Console.ReadLine());
        int pY1 = int.Parse(Console.ReadLine());
        int pX2 = int.Parse(Console.ReadLine());
        int pY2 = int.Parse(Console.ReadLine());
        int fX = int.Parse(Console.ReadLine());
        int fY = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        fX += d;
        int damage = 0;

        int min = Math.Min(pX1, pX2);
        int max = Math.Max(pX1, pX2);
        pX1 = min;
        pX2 = max;
        min = Math.Min(pY1, pY2);
        max = Math.Max(pY1, pY2);
        pY1 = min;
        pY2 = max;

        if ((fX==(pX1-1)) && (fY>=pY1) && (fY<=pY2))
        {
            damage += 75;
        }
        if ((fX>=pX1) && (fX<=pX2) && ((fY==(pY1-1)) || (fY==(pY2+1))))
        {
            damage +=50;
        }
        if ((fX==pX2) && ((fY==pY1) || (fY==pY2))) 
        {
            damage += 150;
        }
        if ((fX==pX2) && (fY>=(pY1+1) || (fY<=(pY2-1))))
        {
            damage += 200;
        }
        if ((fX >= pX1) && (fX < pX2) && ((fY == pY1) || (fY == pY2)))
        {
            damage += 225;
        }
        if ((fX > pX1) && (fX < pX2) && (fY > pY1) && (fY < pY2))
        {
            damage += 275;
        }
        Console.WriteLine(damage + "%");
    }
}

