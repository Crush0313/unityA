using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("누름");
        if (Input.anyKey)
            Debug.Log("누르고 있음");
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("구매 완료");
        if (Input.GetKey(KeyCode.RightArrow))
            Debug.Log("우측으로 이동 중");
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            Debug.Log("좌로 이동을 멈춤");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("기 모으기 시작");
        if (Input.GetMouseButton(0))
            Debug.Log("기 모으는 중");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("기 발사");

        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프");
        if (Input.GetButton("Jump"))
            Debug.Log("점프 기 모으는 중");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("차징 점프");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("횡 이동 중..." + Input.GetAxis("Vertical"));
        }
    }
}
