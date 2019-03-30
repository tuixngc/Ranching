using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooesBtn : MonoBehaviour
{
    public List<GameObject> enable;

    public List<GameObject> disable;
    
    void Start()
    {
        
    }
     public void OnClick()
    {
        foreach (GameObject obj in enable)
        {
            obj.SetActive(true);
        }
        foreach (GameObject obj in disable)
        {
            obj.SetActive(false);
        }
    }
}
