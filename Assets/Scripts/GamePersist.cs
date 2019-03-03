using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        // 初始化food map
        // 从xml或者json加载
        foodMap["0000"] = new FoodType(0, 0, 1);
        foodMap["0101"] = new FoodType(1, 1, 2);

        compoundMap["00000000"] = "0101";
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
