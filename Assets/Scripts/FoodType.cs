using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodType
{
    public FoodType(int main, int sub, int lv)
    {
        if( main <=99&& sub <= 99)
        {
            this.mainType = main;
            this.subType = sub;
            this.level = lv;
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

    public int GetLv()
    {
        return level;
    }

    private int mainType;

    private int subType;

    private int level;

    private string name;
}

