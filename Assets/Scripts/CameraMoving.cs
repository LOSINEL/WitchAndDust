using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    /* �ۼ��� �����
     * ī�޶� �÷��̾� ���󰡴� ��ũ��Ʈ
     */

    public GameObject player;
    private void LateUpdate()
    {
        transform.position = player.transform.position - new Vector3(0, 0, 10);
    }
}