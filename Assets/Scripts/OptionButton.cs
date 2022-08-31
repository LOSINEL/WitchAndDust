using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButton : MonoBehaviour
{
    /* 20220830 작성자 김두현
     * 옵션 버튼, 옵션 윈도우 관리 스크립트
     * 로비, 스테이지에서 사용 가능하도록 구현
     */
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