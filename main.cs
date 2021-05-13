using System;

class MainClass
{

    public static int Main()
    {
        int credit = 50;

        MachineA s = new MachineA(credit);
        s.Lever_On();
        Console.WriteLine(s.get_credit());
        return(0);
    }

}