

public class Program
{
    public static void Main()
    {
        // Box();
        // UpperTrainagle();
        // UpperTriangleNumbers();
        // UpperTrainagleRepeatedNumbers();
        // UltaTriangle();
        // UltaTriangleNumbers();
        // Pyramid();
        UltaPyramid();
    }

    public static void UltaPyramid()
    {
        int n = 5;
        for (int i = n; i > 0 ; i--) //5,4,3,2,1
        {
            for (int p = n - i ; p > 0 ; p--) // 3-3, 0>0
            {
                Console.Write(" ");
            }

            for (int j = i *2 -1; j > 0 ; j--) //9,7,5,3,1
            {
                Console.Write("*");
            }

            for (int p = n - i ; p > 0 ; p--) // 3-3, 0>0
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    public static void Pyramid()
    {
        int length = 3;
        // N = 5 then 0 -> 2 space, 1 -> 1 space, 2 -> no space
        for (int i = 0; i < length; i++)
        {
            for(int p = 0; p < length - i -1  ; p++) // 3-0 -> 5 -
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i*2 + 1 ; j++ )
            {
                Console.Write("*");
            }
            for (int j =0; j<length-i-1; j++)
            {
                Console.Write(" ");
            }
                Console.WriteLine();
        }
    }

    public static void UltaTriangleNumbers()
    {
        // for (int i = 5; i > 0; i--)
        // {
        //     for (int j = 1; j <= i ; j++)
        //     {
        //         Console.Write(j);
        //     }
        //         Console.WriteLine();
        // }

        for (int i = 0; i < 5 ; i++)
        {
            for (int j = 1; j <= 5 - i ; j++)
            {
                Console.Write(j);
            }
                Console.WriteLine();
        }
    }
    public static void UltaTriangle()
    {
        for (int i = 5; i > 0; i--)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write("*");
            }
                Console.WriteLine();
        }
    }

    public static void UpperTrainagleRepeatedNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }

    private static void Box()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

    public static void UpperTrainagle()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
                Console.Write("\n");
        }
    }

    public static void UpperTriangleNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
                Console.Write("\n");
        }
    }
}