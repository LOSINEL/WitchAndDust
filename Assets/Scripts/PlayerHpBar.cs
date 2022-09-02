using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpBar : MonoBehaviour
{
    /* 20220830 ����� �ۼ�
     * �÷��̾� ����¹� ��ũ��Ʈ
     * ������ ���� �޾��� �� RefreshPlayerHpBar() ȣ���ϱ�
     */
    public GameObject player;

    private void Start()
    {
        InitPlayerHpBar();
    }

    void InitPlayerHpBar()
    {
        GetComponent<Image>().fillAmount = 1;
    }

    public void RefreshPlayerHpBar()
    {
        GetComponent<Image>().fillAmount = (float)player.GetComponent<Player>().NowHp / (float)player.GetComponent<Player>().MaxHp;
    }
}