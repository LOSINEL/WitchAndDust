using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    /* 20220830 �ۼ��� �����
     * ���� �޴��� �ִ� ��ư ������ �� ��ȣ�ۿ� �ϱ� ���� ��ũ��Ʈ
     */
    public void SelectGameStartButton()
    {
        SceneManager.LoadScene("Lobby");
    }
}