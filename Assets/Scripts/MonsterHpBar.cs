using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHpBar : MonoBehaviour
{
    public Image hpBar;
    public void RefreshHpBar()
    {
        hpBar.fillAmount = (float)GetComponent<Monster>().nowHp / (float)GetComponent<Monster>().maxHp;
    }
}