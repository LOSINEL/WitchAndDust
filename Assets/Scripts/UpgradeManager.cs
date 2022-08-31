using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    /* 20220829 작성자 김두현
     * 플레이어 캐릭터의 업그레이드 상태를 관리해주는 스크립트
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