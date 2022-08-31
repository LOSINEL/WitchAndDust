using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    /* 작성자 김두현
     * 카메라가 플레이어 따라가는 스크립트
     */

    public GameObject player;
    private void LateUpdate()
    {
        transform.position = player.transform.position - new Vector3(0, 0, 10);
    }
}