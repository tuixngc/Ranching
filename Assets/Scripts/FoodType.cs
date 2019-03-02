using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodType
{
    public FoodType(int main, int sub)
    {
        if( main <=99&& sub <= 99)
        {
            this.mainType = main;
            this.subType = sub;
        }
        
    }

    public string GetMain()
    {
        string str = "" + mainType + subType;
        return str;
    }

    public string GetSub()
    {
        string str = "" + mainType + "00";
        return str;
    }

    private int mainType;

    private int subType;
}

