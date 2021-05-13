using System;

class MachineA : Slot
{

    public MachineA(int arg_credit) : base(arg_credit)
    {
        bonus_p=0.5;
    }

    public override bool Lever_On(){
        Random r1 = new System.Random();
        if(r1.NextDouble() < bonus_p){
            credit=(int)(1.5*(double)credit);
        }
        else{
            credit=(int)(0.5*(double)credit);
        }
        return(true);
    }
    
}