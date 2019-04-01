using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class XmlReader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("D:/xsh/Ranching/compound.xml");

        XmlNode lv2 = doc.SelectSingleNode("//level_2");
        // 父类
        foreach (XmlElement sup in lv2.ChildNodes)
        {
            // 食物的父类型
            string mainStr = sup.Attributes["id"].Value;
            int mainType = int.Parse(mainStr);
            Debug.Log(sup.Attributes["id"].Value);
            // 子类型
            foreach (XmlElement sub in sup.ChildNodes)
            {
                string subStr = sub.GetElementsByTagName("identifier")[0].InnerText;
                int subType = int.Parse(subStr);
            }
        }


        foreach (KeyValuePair<string, FoodType> pair in GamePersist.Get().foodMap)
        {
            FoodType ft = pair.Value;

                Debug.Log(pair.Key);
                Debug.Log(ft.GetName());
                Debug.Log(ft.GetSub());

        }

        foreach (KeyValuePair<string, string> pair in GamePersist.Get().compoundMap)
        {
            Debug.Log("compound");
            Debug.Log(pair.Key);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
