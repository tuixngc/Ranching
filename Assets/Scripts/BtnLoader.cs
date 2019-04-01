using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro.Examples;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BtnLoader : MonoBehaviour
{
    public GameObject foodBtn;

    public SceneData sceneData;

    public List<GameObject> content;

    void Start()
    {
        foreach(KeyValuePair<string, FoodType> pair in GamePersist.Get().foodMap)
        {
            FoodType ft = pair.Value;
            if (pair.Value.GetLv() == 1)
            {
                string name = pair.Value.GetName();
                GameObject btn = Instantiate(foodBtn);
                btn.GetComponent<FoodBtn>().name = pair.Value.GetSub();
                btn.GetComponent<FoodBtn>().foodName = pair.Value.GetSub();
                btn.GetComponent<FoodBtn>().data = sceneData;
                btn.GetComponentInChildren<Text>().text = name;
                //btn.GetComponentInChildren(Textme)

                btn.transform.parent = content[ft.mainType-1].transform;
            }
                
        }
    }
}
