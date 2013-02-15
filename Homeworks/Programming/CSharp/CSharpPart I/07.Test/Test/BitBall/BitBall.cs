using System;

class BitBall
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        int n6 = int.Parse(Console.ReadLine());
        int n7 = int.Parse(Console.ReadLine());
        int n8 = int.Parse(Console.ReadLine());
        int n11 = int.Parse(Console.ReadLine());
        int n12 = int.Parse(Console.ReadLine());
        int n13 = int.Parse(Console.ReadLine());
        int n14 = int.Parse(Console.ReadLine());
        int n15 = int.Parse(Console.ReadLine());
        int n16 = int.Parse(Console.ReadLine());
        int n17 = int.Parse(Console.ReadLine());
        int n18 = int.Parse(Console.ReadLine());

        int x = 0;
        int y = 0;
        
        for (int i = 0; i <= 7; i++)
        {
            int mask = 1;
            mask = mask << i;
            if (((n1 & mask) & (n11 & mask)) == 1)
            {
                n1 = n1 & (~(1 << i));
                n11 = n11 & (~(1 << i));
            }
            if (((n1 & mask) & (n12 & mask)) == 1)
            {
                n1 = n1 & (~(1 << i));
                n12 = n12 & (~(1 << i));
            }
            if (((n1 & mask) & (n13 & mask)) == 1)
            {
                n1 = n1 & (~(1 << i));
                n13 = n13 & (~(1 << i));
            } 
            if (((n1 & mask) & (n14 & mask)) == 1)
            {
                n1 = n1 & (~(1 << i));
                n14 = n14 & (~(1 << i));
            } 
            if (((n1 & mask) & (n15 & mask)) == 1)
            {
                n1 = n1 & (~(1 << i));
                n15 = n15 & (~(1 << i));
            } 
            if (((n1 & mask) & (n16 & mask)) == 1)
            {
                n1 = n1 & (~(1 << i));
                n16 = n16 & (~(1 << i));
            } 
            if (((n1 & mask) & (n17 & mask)) == 1)
            {
                n1 = n1 & (~(1 << i));
                n17 = n17 & (~(1 << i));
            } 
            if (((n1 & mask) & (n18 & mask)) == 1)
            {
                n1 = n1 & (~(1 << i));
                n18 = n18 & (~(1 << i));
            }
            if (((n2 & mask) & (n11 & mask)) == 1)
            {
                n2 = n2 & (~(1 << i));
                n11 = n11 & (~(1 << i));
            }
            if (((n2 & mask) & (n12 & mask)) == 1)
            {
                n2 = n2 & (~(1 << i));
                n12 = n12 & (~(1 << i));
            }
            if (((n2 & mask) & (n13 & mask)) == 1)
            {
                n2 = n2 & (~(1 << i));
                n13 = n13 & (~(1 << i));
            }
            if (((n2 & mask) & (n14 & mask)) == 1)
            {
                n2 = n2 & (~(1 << i));
                n14 = n14 & (~(1 << i));
            }
            if (((n2 & mask) & (n15 & mask)) == 1)
            {
                n2 = n2 & (~(1 << i));
                n15 = n15 & (~(1 << i));
            }
            if (((n2 & mask) & (n16 & mask)) == 1)
            {
                n2 = n2 & (~(1 << i));
                n16 = n16 & (~(1 << i));
            } 
            if (((n2 & mask) & (n17 & mask)) == 1)
            {
                n2 = n2 & (~(1 << i));
                n17 = n17 & (~(1 << i));
            } 
            if (((n2 & mask) & (n18 & mask)) == 1)
            {
                n2 = n2 & (~(1 << i));
                n18 = n18 & (~(1 << i));
            }
            if (((n3 & mask) & (n11 & mask)) == 1)
            {
                n3 = n3 & (~(1 << i));
                n11 = n11 & (~(1 << i));
            }
            if (((n3 & mask) & (n12 & mask)) == 1)
            {
                n3 = n3 & (~(1 << i));
                n12 = n12 & (~(1 << i));
            }
            if (((n3 & mask) & (n13 & mask)) == 1)
            {
                n3 = n3 & (~(1 << i));
                n13 = n13 & (~(1 << i));
            }
            if (((n3 & mask) & (n14 & mask)) == 1)
            {
                n3 = n3 & (~(1 << i));
                n14 = n14 & (~(1 << i));
            }
            if (((n3 & mask) & (n15 & mask)) == 1)
            {
                n3 = n3 & (~(1 << i));
                n15 = n15 & (~(1 << i));
            }
            if (((n3 & mask) & (n16 & mask)) == 1)
            {
                n3 = n3 & (~(1 << i));
                n16 = n16 & (~(1 << i));
            }
            if (((n3 & mask) & (n17 & mask)) == 1)
            {
                n3 = n3 & (~(1 << i));
                n17 = n17 & (~(1 << i));
            }
            if (((n3 & mask) & (n18 & mask)) == 1)
            {
                n3 = n3 & (~(1 << i));
                n18 = n18 & (~(1 << i));
            }
            if (((n4 & mask) & (n11 & mask)) == 1)
            {
                n4 = n4 & (~(1 << i));
                n11 = n11 & (~(1 << i));
            }
            if (((n4 & mask) & (n12 & mask)) == 1)
            {
                n4 = n4 & (~(1 << i));
                n12 = n12 & (~(1 << i));
            }
            if (((n4 & mask) & (n13 & mask)) == 1)
            {
                n4 = n4 & (~(1 << i));
                n13 = n13 & (~(1 << i));
            }
            if (((n4 & mask) & (n14 & mask)) == 1)
            {
                n4 = n4 & (~(1 << i));
                n14 = n14 & (~(1 << i));
            }
            if (((n4 & mask) & (n15 & mask)) == 1)
            {
                n4 = n4 & (~(1 << i));
                n15 = n15 & (~(1 << i));
            }
            if (((n4 & mask) & (n16 & mask)) == 1)
            {
                n4 = n4 & (~(1 << i));
                n16 = n16 & (~(1 << i));
            }
            if (((n4 & mask) & (n17 & mask)) == 1)
            {
                n4 = n4 & (~(1 << i));
                n17 = n17 & (~(1 << i));
            }
            if (((n4 & mask) & (n18 & mask)) == 1)
            {
                n4 = n4 & (~(1 << i));
                n18 = n18 & (~(1 << i));
            }
            if (((n5 & mask) & (n11 & mask)) == 1)
            {
                n5 = n5 & (~(1 << i));
                n11 = n11 & (~(1 << i));
            }
            if (((n5 & mask) & (n12 & mask)) == 1)
            {
                n5 = n5 & (~(1 << i));
                n12 = n12 & (~(1 << i));
            }
            if (((n5 & mask) & (n13 & mask)) == 1)
            {
                n5 = n5 & (~(1 << i));
                n13 = n13 & (~(1 << i));
            }
            if (((n5 & mask) & (n14 & mask)) == 1)
            {
                n5 = n5 & (~(1 << i));
                n14 = n14 & (~(1 << i));
            }
            if (((n5 & mask) & (n15 & mask)) == 1)
            {
                n5 = n5 & (~(1 << i));
                n15 = n15 & (~(1 << i));
            }
            if (((n5 & mask) & (n16 & mask)) == 1)
            {
                n5 = n5 & (~(1 << i));
                n16 = n16 & (~(1 << i));
            }
            if (((n5 & mask) & (n17 & mask)) == 1)
            {
                n5 = n5 & (~(1 << i));
                n17 = n17 & (~(1 << i));
            }
            if (((n5 & mask) & (n18 & mask)) == 1)
            {
                n5 = n5 & (~(1 << i));
                n18 = n18 & (~(1 << i));
            }
            if (((n6 & mask) & (n11 & mask)) == 1)
            {
                n6 = n6 & (~(1 << i));
                n11 = n11 & (~(1 << i));
            }
            if (((n6 & mask) & (n12 & mask)) == 1)
            {
                n6 = n6 & (~(1 << i));
                n12 = n12 & (~(1 << i));
            }
            if (((n6 & mask) & (n13 & mask)) == 1)
            {
                n6 = n6 & (~(1 << i));
                n13 = n13 & (~(1 << i));
            }
            if (((n6 & mask) & (n14 & mask)) == 1)
            {
                n6 = n6 & (~(1 << i));
                n14 = n14 & (~(1 << i));
            }
            if (((n6 & mask) & (n15 & mask)) == 1)
            {
                n6 = n6 & (~(1 << i));
                n15 = n15 & (~(1 << i));
            }
            if (((n6 & mask) & (n16 & mask)) == 1)
            {
                n6 = n6 & (~(1 << i));
                n16 = n16 & (~(1 << i));
            }
            if (((n6 & mask) & (n17 & mask)) == 1)
            {
                n6 = n6 & (~(1 << i));
                n17 = n17 & (~(1 << i));
            }
            if (((n6 & mask) & (n18 & mask)) == 1)
            {
                n6 = n6 & (~(1 << i));
                n18 = n18 & (~(1 << i));
            }
            if (((n7 & mask) & (n11 & mask)) == 1)
            {
                n7 = n7 & (~(1 << i));
                n11 = n11 & (~(1 << i));
            }
            if (((n7 & mask) & (n12 & mask)) == 1)
            {
                n7 = n7 & (~(1 << i));
                n12 = n12 & (~(1 << i));
            }
            if (((n7 & mask) & (n13 & mask)) == 1)
            {
                n7 = n7 & (~(1 << i));
                n13 = n13 & (~(1 << i));
            }
            if (((n7 & mask) & (n14 & mask)) == 1)
            {
                n7 = n7 & (~(1 << i));
                n14 = n14 & (~(1 << i));
            }
            if (((n7 & mask) & (n15 & mask)) == 1)
            {
                n7 = n7 & (~(1 << i));
                n15 = n15 & (~(1 << i));
            }
            if (((n7 & mask) & (n16 & mask)) == 1)
            {
                n7 = n7 & (~(1 << i));
                n16 = n16 & (~(1 << i));
            }
            if (((n7 & mask) & (n17 & mask)) == 1)
            {
                n7 = n7 & (~(1 << i));
                n17 = n17 & (~(1 << i));
            }
            if (((n7 & mask) & (n18 & mask)) == 1)
            {
                n7 = n7 & (~(1 << i));
                n18 = n18 & (~(1 << i));
            }
            if (((n8 & mask) & (n11 & mask)) == 1)
            {
                n8 = n8 & (~(1 << i));
                n11 = n11 & (~(1 << i));
            }
            if (((n8 & mask) & (n12 & mask)) == 1)
            {
                n8 = n8 & (~(1 << i));
                n12 = n12 & (~(1 << i));
            }
            if (((n8 & mask) & (n13 & mask)) == 1)
            {
                n8 = n8 & (~(1 << i));
                n13 = n13 & (~(1 << i));
            }
            if (((n8 & mask) & (n14 & mask)) == 1)
            {
                n8 = n8 & (~(1 << i));
                n14 = n14 & (~(1 << i));
            }
            if (((n8 & mask) & (n15 & mask)) == 1)
            {
                n8 = n8 & (~(1 << i));
                n15 = n15 & (~(1 << i));
            }
            if (((n8 & mask) & (n16 & mask)) == 1)
            {
                n8 = n8 & (~(1 << i));
                n16 = n16 & (~(1 << i));
            }
            if (((n8 & mask) & (n17 & mask)) == 1)
            {
                n8 = n8 & (~(1 << i));
                n17 = n17 & (~(1 << i));
            }
            if (((n8 & mask) & (n18 & mask)) == 1)
            {
                n8 = n8 & (~(1 << i));
                n18 = n18 & (~(1 << i));
            }
        }
        for (int j = 0; j <= 7; j++)
        {
            int mask1 = 1;
            mask1 = mask1 << j;
            int n1n = n1 & mask1;
            if ((n1n==1 ) & ((n11 | n12 | n13 | n14 | n15 | n16 | n17 | n18) & (1<<j)) == 0)
            {
                x += 1;
            }
            int n2n = n2 & mask1;
            if ((n2n == 1) & ((n11 | n12 | n13 | n14 | n15 | n16 | n17 | n18) & (1 << j)) == 0)
            {
                x += 1;
            } int n3n = n3 & mask1;
            if ((n3n == 1) & ((n11 | n12 | n13 | n14 | n15 | n16 | n17 | n18) & (1 << j)) == 0)
            {
                x += 1;
            } 
            int n4n = n4 & mask1;
            if ((n4n == 1) & ((n11 | n12 | n13 | n14 | n15 | n16 | n17 | n18) & (1 << j)) == 0)
            {
                x += 1;
            } 
            int n5n = n5 & mask1;
            if ((n5n == 1) & ((n11 | n12 | n13 | n14 | n15 | n16 | n17 | n18) & (1 << j)) == 0)
            {
                x += 1;
            } 
            int n6n = n6 & mask1;
            if ((n6n == 1) & ((n11 | n12 | n13 | n14 | n15 | n16 | n17 | n18) & (1 << j)) == 0)
            {
                x += 1;
            } 
            int n7n = n7 & mask1;
            if ((n7n == 1) & ((n11 | n12 | n13 | n14 | n15 | n16 | n17 | n18) & (1 << j)) == 0)
            {
                x += 1;
            }
            int n8n = n8 & mask1;
            if ((n8n == 1) & ((n11 | n12 | n13 | n14 | n15 | n16 | n17 | n18) & (1 << j)) == 0)
            {
                x += 1;
            }
            int n11n = n11 & mask1;
            if ((n11n == 1) & ((n1 | n2 | n3 | n4 | n5 | n6 | n7 | n8) & (1<<j)) == 0)
            {
                y += 1;
            }
            int n12n = n12 & mask1;
            if ((n12n == 1) & ((n1 | n2 | n3 | n4 | n5 | n6 | n7 | n8) & (1 << j)) == 0)
            {
                y += 1;
            }
            int n13n = n13 & mask1;
            if ((n13n == 1) & ((n1 | n2 | n3 | n4 | n5 | n6 | n7 | n8) & (1 << j)) == 0)
            {
                y += 1;
            } 
            int n14n = n14 & mask1;
            if ((n14n == 1) & ((n1 | n2 | n3 | n4 | n5 | n6 | n7 | n8) & (1 << j)) == 0)
            {
                y += 1;
            } 
            int n15n = n15 & mask1;
            if ((n15n == 1) & ((n1 | n2 | n3 | n4 | n5 | n6 | n7 | n8) & (1 << j)) == 0)
            {
                y += 1;
            } 
            int n16n = n16 & mask1;
            if ((n16n == 1) & ((n1 | n2 | n3 | n4 | n5 | n6 | n7 | n8) & (1 << j)) == 0)
            {
                y += 1;
            } 
            int n17n = n17 & mask1;
            if ((n17n == 1) & ((n1 | n2 | n3 | n4 | n5 | n6 | n7 | n8) & (1 << j)) == 0)
            {
                y += 1;
            } 
            int n18n = n18 & mask1;
            if ((n18n == 1) & ((n1 | n2 | n3 | n4 | n5 | n6 | n7 | n8) & (1 << j)) == 0)
            {
                y += 1;
            }
        }
        Console.WriteLine(x+":"+y);
    }
}

