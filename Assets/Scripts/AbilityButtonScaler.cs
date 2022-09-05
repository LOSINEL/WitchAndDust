using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityButtonScaler : MonoBehaviour
{
    public float x, y;
    GridLayoutGroup gridLayoutGroup;
    void Start()
    {
        StartCoroutine(ScaleWindow());
    }
    IEnumerator ScaleWindow()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            gridLayoutGroup = GetComponent<GridLayoutGroup>();
            gridLayoutGroup.cellSize = new Vector2(Screen.currentResolution.width / x, Screen.currentResolution.height / y);
        }
    }
}