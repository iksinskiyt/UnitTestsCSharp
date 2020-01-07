using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Hello World!");

       int yy = Add(4,5);
       Console.WriteLine(yy);

       Console.WriteLine(IsOdd(9));
    }

    public static int Add(int x,int y){
        return x+y;
    }

    public static bool IsOdd(int value){
        return value % 2 == 1;
    }
}    