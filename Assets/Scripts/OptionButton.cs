using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButton : MonoBehaviour
{
    /* 20220830 �ۼ��� �����
     * �ɼ� ��ư, �ɼ� ������ ���� ��ũ��Ʈ
     * �κ�, ������������ ��� �����ϵ��� ����
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