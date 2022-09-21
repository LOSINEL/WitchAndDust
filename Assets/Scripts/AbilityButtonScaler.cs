using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityButtonScaler : MonoBehaviour
{
    [Range(0.1f,5f)]
    public float xSize;
    [Range(0.1f,5f)]
    public float ySize;
    private void Update()
    {
        GetComponent<GridLayoutGroup>().cellSize = new Vector2(Screen.currentResolution.width / xSize, Screen.currentResolution.height / ySize);
        Debug.Log(Screen.currentResolution);
    }
}