using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ItemBox[] itemBoxes; // ItemBox 배열 선언
    public Boolean isGameover = false; // 게임 오버 상태 변수
    void Start()
    {
        isGameover = false; // 게임 오버 상태를 게임 중으로 변경
    }

    void Update()
    {
        if (isGameover) return; // 게임 오버 상태라면 업데이트를 진행하지 않음
        
        int count = 0; // ItemBox 중에서 충돌한 ItemBox의 개수를 저장할 변수
        for(int i = 0; i < 3; i++) // 3개의 ItemBox를 모두 확인
        {
            if (itemBoxes[i].isOveraped) // 만약 ItemBox가 isOveraped가 true라면
            {
                count++; // count를 1 증가
            }
        }

        if(count >= 3) // 만약 충돌한 ItemBox의 개수가 3개 이상이라면
        {
            Debug.Log("게임 승리"); 
            isGameover = true; // 게임 오버 상태를 게임 승리로 변경
        }
    }
}
