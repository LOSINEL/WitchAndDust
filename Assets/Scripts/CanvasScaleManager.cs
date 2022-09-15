using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScaleManager : MonoBehaviour
{
    private void Start()
    {
        GetComponent<CanvasScaler>().referenceResolution = new Vector2(Screen.currentResolution.width, Screen.currentResolution.height);
    }
}