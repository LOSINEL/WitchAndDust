using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpBar : MonoBehaviour
{
    /* 20220830 김두현 작성
     * 플레이어 생명력바 스크립트
     * 적에게 공격 받았을 때 RefreshPlayerHpBar() 호출하기
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