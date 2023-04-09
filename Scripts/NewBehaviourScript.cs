using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    //생성 시 최초
    private void Awake()
    {
        Debug.Log("플레이어 데이터 준비");
    }
    private void OnEnable()
    {
        Debug.Log("플레이어가 로그인하였습니다");

    }
    // 업데이트 전
    void Start()
    {
        Debug.Log("장비를 챙깁니다");
    }
    //물리 연산 업데이트, cpu 많이 먹음, 하드웨어 차이없이 고정 주기, 50프레임
    private void FixedUpdate()
    {
        Debug.Log("이동");

    }

    //게임 로직 업데이트, 60프레임
    private void Update()
    {
        Debug.Log("사냥");

    }
    //모든 업데이트 이후
    private void LateUpdate()
    {
        Debug.Log("경험치 획득");

    }

    private void OnDestroy()
    {
        Debug.Log("플레이어가 로그아웃하였습니다");

    }
    private void OnDisable()
    {
        Debug.Log("플레이어 데이터를 해체했습니다");

    }
}
