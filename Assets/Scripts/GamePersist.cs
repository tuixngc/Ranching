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
    }

    private Dictionary<string, string> foodMap;

    private void Init()
    {
        // 初始化food map
        // 从xml或者json加载
    }

    public bool InsertRecord(string input, string result)
    {
        foodMap.Add(input, result);
        return true;
    }

    public string GetResult(string input)
    {
        return foodMap[input];
    }
}
