using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("����");
        if (Input.anyKey)
            Debug.Log("������ ����");
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("���� �Ϸ�");
        if (Input.GetKey(KeyCode.RightArrow))
            Debug.Log("�������� �̵� ��");
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            Debug.Log("�·� �̵��� ����");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("�� ������ ����");
        if (Input.GetMouseButton(0))
            Debug.Log("�� ������ ��");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("�� �߻�");

        if (Input.GetButtonDown("Jump"))
            Debug.Log("����");
        if (Input.GetButton("Jump"))
            Debug.Log("���� �� ������ ��");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("��¡ ����");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Vertical"));
        }
    }
}
