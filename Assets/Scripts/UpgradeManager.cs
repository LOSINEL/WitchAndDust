using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    /* 20220829 �ۼ��� �����
     * �÷��̾� ĳ������ ���׷��̵� ���¸� �������ִ� ��ũ��Ʈ
     */

    public static UpgradeManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}