using System;

class viewclock
{
    static int x;static int y;static String s = "";
    public static void Views() 
    {
        DateTime now = DateTime.Now;
        Console.SetCursorPosition(x, y);
        Console.WriteLine(s+now.ToString());
    
    
    }
    public static void clockLoop(int xx, int yy, String ss)
    { 
        x= xx; y = yy; s = ss;
        while (true)
        {
            Views();
            System.Threading.Thread.Sleep(1000);
            if (Console.KeyAvailable) break;
        }
    }


}







class clocks
{

    public static void Main()
    {

        Console.BackgroundColor= ConsoleColor.White;
        Console.ForegroundColor= ConsoleColor.Black;
        Console.Clear();
        viewclock.clockLoop(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2, ":");



    }






}

