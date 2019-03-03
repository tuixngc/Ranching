using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Compound : MonoBehaviour
{

    void Update()
    {
        CheckData();
    }

    public List<Image> images;

    public SceneData data;

    private void CheckData()
    {
        int i = 0;
        //Debug.Log(data.list.Count);
        foreach(FoodType ft in data.list)
        {
            // 通过foodType动态加载图片
            Debug.Log(ft.GetSprite());
            Sprite tx= Resources.Load<Sprite>(ft.GetSprite());
            if(tx!=null)
                Debug.Log(tx);
            images[i].sprite = tx;
            i++;
        }

        for (; i < 5; i++)
        {
            images[i].sprite = null;
        }
    }
}
