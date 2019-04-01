using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class GamePersist
{
    static private GamePersist gamePersist;

    static public GamePersist Get()
    {
        if (gamePersist == null)
            gamePersist = new GamePersist();
        return gamePersist;
    }

    GamePersist()
    {
        Init();
    }

    public Dictionary<string, string> compoundMap = new Dictionary<string, string>();
    public Dictionary<string, FoodType> foodMap = new Dictionary<string, FoodType>();

    private void Init()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("D:/xsh/Ranching/compound.xml");

        // 加载lv1的数据 初始化foodMap
        XmlNode lv1 = doc.SelectSingleNode("//level_1");
        // 父类
        foreach (XmlElement sup in lv1.ChildNodes)
        {
            // 食物的父类型
            string mainStr = sup.Attributes["id"].Value;
            int mainType = int.Parse(mainStr);
            // 子类型
            foreach (XmlElement sub in sup.ChildNodes)
            {
                string subStr = sub.GetElementsByTagName("identifier")[0].InnerText;
                int subType = int.Parse(subStr);
                // Debug.Log(sub.LocalName);

                foodMap["0" + mainStr + subStr] = new FoodType(mainType, subType, 1, sub.LocalName);
            }
        }
        //foodMap["0000"] = new FoodType(0, 0, 1);
        //foodMap["0101"] = new FoodType(1, 1, 2);

        // 加载lv2的数据 初始化foodMap 和 compoundMap
        XmlNode lv2 = doc.SelectSingleNode("//level_2");
        // 父类
        foreach (XmlElement sup in lv2.ChildNodes)
        {
            // 食物的父类型
            string mainStr = sup.Attributes["id"].Value;
            int mainType = int.Parse(mainStr);
            // Debug.Log(sup.Attributes["id"].Value);
            // 子类型
            foreach (XmlElement sub in sup.ChildNodes)
            {
                string subStr = sub.GetElementsByTagName("identifier")[0].InnerText;
                int subType = int.Parse(subStr);

                // 存入food
                foodMap[subStr] = new FoodType(mainType, subType, 2, sub.LocalName);
                compoundMap[subStr] = subStr;
            }
        }

        // compoundMap["00000000"] = "0101";
    }

    public bool InsertRecord(string input, string result)
    {
        compoundMap.Add(input, result);
        return true;
    }

    public string GetResult(string input)
    {
        return compoundMap[input];
    }
}
