using UnityEngine;
using UnityEngine.UI;

public class FoodBtn : MonoBehaviour
{
    private void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Debug.Log("click");
        data.InsertFoodType(foodName);
    }

    public SceneData data;

    public string foodName = "0000";

}
