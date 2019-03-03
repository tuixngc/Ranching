using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneData : MonoBehaviour
{
    // 存储用来合成的五个物品
    private List<FoodType> list;

    public void InsertFoodType(string foodType)
    {
        if(list.Count < 5)
        {
            // 先进行查找
            // 由str -> foodtype的映射
            FoodType ft = GamePersist.Get().foodMap[foodType];
            list.Add(ft);
        }
    }

    public void Clear()
    {
        //list.Clear();
        Debug.Log("clear");
    }

    public void Compound()
    {
        Debug.Log("compound");
    }

    public void ExitScene()
    {
        Debug.Log("exit");
        
    }
}
