using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager; // 게임 매니저

    // 플레이어의 이동 속도
    public float speed = 10f;

    // 플레이어의 리지드바디 컴포넌트
    Rigidbody playerRigidbody;

    // 게임이 시작될 때 한 번만 호출되는 함수 -> 초기화
    void Start()
    {
        // GetComponent<타입>() : 타입에 해당하는 컴포넌트를 찾아서 반환
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // 매 프레임마다 호출되는 함수 -> 유저 입력을 받아서 처리
    void Update()
    {
        if (gameManager.isGameover) return; // 게임 오버 상태라면 업데이트를 진행하지 않음

        // GetAxis() : 키보드 입력을 받아서 -1 ~ 1 사이의 값을 반환
        float inpuitX = Input.GetAxis("Horizontal"); // 조이스틱 대응 가능
        float inputZ = Input.GetAxis("Vertical"); 
        float fallSpeed = playerRigidbody.velocity.y; // 중력에 의해 떨어지는 속도를 유지시키기 위해

        // 방향 * 속도 = 속도 벡터
        Vector3 velocity = new Vector3(inpuitX, 0f, inputZ);

        velocity = velocity * speed; // 방향 * 속도
        velocity.y = fallSpeed; // 중력에 의해 떨어지는 속도를 유지시키기 위해

        // 리지드바디의 속도를 velocity로 변경
        playerRigidbody.velocity = velocity;
    }
}
