using System;

class MachineB : Slot
{

    public MachineB(int arg_credit) : base(arg_credit)
    {
        bonus_p=0.9;
    }

    public override bool Lever_On(){
        Random r1 = new System.Random();
        if(r1.NextDouble() < bonus_p){
            credit=(int)(1.1*(double)credit);
        }
        else{
            credit=0;
        }
        return(true);
    }
    
}