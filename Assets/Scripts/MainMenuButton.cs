using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    /* 20220830 작성자 김두현
     * 메인 메뉴에 있는 버튼 눌렀을 때 상호작용 하기 위한 스크립트
     */
    public void SelectGameStartButton()
    {
        SceneManager.LoadScene("Lobby");
    }
}