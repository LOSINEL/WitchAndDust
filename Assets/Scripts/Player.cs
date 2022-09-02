using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /* 20220829
     * 플레이어의 레벨, 생명력 등이 들어있는 스크립트
     */

    int nowHp, maxHp, level;
    float moveSpeed;
    int nowExp, maxExp;
    public GameObject playerHpBar;
    public GameObject abilityWindow;
    int abilitySelectNum = 1;

    public int NowHp { get { return nowHp; } }
    public int MaxHp { get { return maxHp; } }
    public int NowExp { get { return nowExp; } }
    public int AbilitySelectNum { get { return abilitySelectNum; } set { abilitySelectNum = value; } }

    private void Start()
    {
        InitPlayerInfo();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(Time.deltaTime * moveSpeed, 0, 0));
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(Time.deltaTime * moveSpeed, 0, 0));
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, Time.deltaTime * moveSpeed, 0));
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -1 * Time.deltaTime * moveSpeed, 0));
        }
    }

    public void AddHp(int _hp)
    {
        nowHp += _hp;
        playerHpBar.GetComponent<PlayerHpBar>().RefreshPlayerHpBar();
        CheckDead();
    }

    void CheckDead()
    {
        if(nowHp<=0)
        {
            PlayerDead();
        }
    }
    bool GetPlayerLive()
    {
        if (nowHp <= 0) return false;
        else return true;
    }

    public void PlayerDead()
    {
        Time.timeScale = 0f;
    }

    void LevelUp()
    {
        nowHp = maxHp;
        level++;
        abilityWindow.SetActive(true);
    }

    void CheckLevelUp()
    {
        if (nowExp >= maxExp)
        {
            LevelUp();
            nowExp = nowExp - maxExp;
            maxExp = 0;
        }
    }

    public void InitPlayerInfo()
    {
        level = 1;
        maxHp = nowHp = 100;
        moveSpeed = 150f;
        nowExp = 0;
        maxExp = 10;
    }

    public void AddExp(int num)
    {
        nowExp += num;
        CheckLevelUp();
    }
}