using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButton : MonoBehaviour
{
    public static OptionButton instance;
    public GameObject optionGrayWindow;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    public void SelectOptionButtonOpen()
    {
        optionGrayWindow.SetActive(true);
    }

    public void SelectOptionButtonClose()
    {
        optionGrayWindow.SetActive(false);
    }
}