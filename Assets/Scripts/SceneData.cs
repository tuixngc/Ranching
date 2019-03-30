using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneData : MonoBehaviour
{
    // 存储用来合成的五个物品
    public List<FoodType> list = new List<FoodType>();

    public Image result;

    public void InsertFoodType(string foodType)
    {
        if(list.Count < 5)
        {
            Debug.Log(foodType);
            // 先进行查找
            // 由str -> foodtype的映射
            FoodType ft = GamePersist.Get().foodMap[foodType];
            Debug.Log(ft);
            list.Add(ft);
        }
    }


    public void Clear()
    {
        if (list.Count > 0)
            list.Clear();
        result.sprite = null;
        Debug.Log("clear");
    }

    public void Compound()
    {
        // 合成策略
        // 目前采用最简单的
        Debug.Log("compound");
        string str = list[0].GetSub() + list[1].GetSub();
        str = GamePersist.Get().compoundMap[str];

        result.sprite = Resources.Load<Sprite>(str);
    }

    public void ExitScene()
    {

        SceneManager.LoadScene(0);
        Debug.Log("exit");
        
    }
}
