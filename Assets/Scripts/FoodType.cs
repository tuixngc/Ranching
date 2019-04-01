using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodType
{
    public FoodType(int main, int sub, int lv, string name)
    {
            this.mainType = main;
            this.subType = sub;
            this.level = lv;
            this.name = name;
    }

    public string GetMain()
    {
        string str;
        if (mainType > 9)
            str = "" + mainType + "00";
        else
            str = "0" + mainType + "00";
        return str;
    }

    public string GetSub()
    {
        int result = mainType * 100 + subType;
        string str;
        if (result > 999)
            str = "" + result;
        else if (result > 99)
            str = "0" + result;
        else if (result > 9)
            str = "00" + result;
        else
            str = "000" + result;
        return str;
    }

    public string GetSprite()
    {
        return name;
    }

    public int GetLv()
    {
        return level;
    }

    public string GetName()
    {
        return name;
    }

    public int mainType;

    private int subType;

    private int level;

    private string name;
}

