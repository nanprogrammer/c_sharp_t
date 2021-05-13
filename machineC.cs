using System;

class MachineC : Slot
{

    public MachineC(int arg_credit) : base(arg_credit)
    {
        bonus_p=0.5;
    }

    public override bool Lever_On(){
        if(credit-10 <= 0){
            Console.WriteLine("no enough credit");
        }
        else{
            credit = credit=10;
        }
        Random r1 = new System.Random();
        if(r1.NextDouble() < bonus_p){
            credit=(int)(2.0*(double)credit);
        }
        else{
            credit=(int)(0.5*(double)credit);
        }
        return(true);
    }
    
}