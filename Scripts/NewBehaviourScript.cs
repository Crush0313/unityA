using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    //���� �� ����
    private void Awake()
    {
        Debug.Log("�÷��̾� ������ �غ�");
    }
    private void OnEnable()
    {
        Debug.Log("�÷��̾ �α����Ͽ����ϴ�");

    }
    // ������Ʈ ��
    void Start()
    {
        Debug.Log("��� ì��ϴ�");
    }
    //���� ���� ������Ʈ, cpu ���� ����, �ϵ���� ���̾��� ���� �ֱ�, 50������
    private void FixedUpdate()
    {
        Debug.Log("�̵�");

    }

    //���� ���� ������Ʈ, 60������
    private void Update()
    {
        Debug.Log("���");

    }
    //��� ������Ʈ ����
    private void LateUpdate()
    {
        Debug.Log("����ġ ȹ��");

    }

    private void OnDestroy()
    {
        Debug.Log("�÷��̾ �α׾ƿ��Ͽ����ϴ�");

    }
    private void OnDisable()
    {
        Debug.Log("�÷��̾� �����͸� ��ü�߽��ϴ�");

    }
}
