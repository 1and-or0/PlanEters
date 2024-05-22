using UnityEngine;

public class MyUiSet : MonoBehaviour
{
    [SerializeField] GameObject mapUiSet, jointUiSet, mapObj;

    public void JointBtnClick()
    {
        mapObj.SetActive(false);
        mapUiSet.SetActive(false);
        jointUiSet.SetActive(true);
    }

    public void BackToMap()
    {
        mapObj.SetActive(true);
        mapUiSet.SetActive(true);
        jointUiSet.SetActive(false);
    }
}
