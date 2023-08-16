using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winUI; // 게임 승리시 활성화할 UI 게임 오브젝트
    public ItemBox[] itemBoxes; // ItemBox 배열 선언
    public Boolean isGameover = false; // 게임 오버 상태 변수
    void Start()
    {
        isGameover = false; // 게임 오버 상태를 게임 중으로 변경
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene(0); // 씬의 순번으로 로드
            SceneManager.LoadScene("Sokovan/Scenes/Main"); // 씬의 이름으로 로드
        }

        if (isGameover) return; // 게임 오버 상태라면 업데이트를 진행하지 않음
        
        int count = 0; // ItemBox 중에서 충돌한 ItemBox의 개수를 저장할 변수
        for(int i = 0; i < 3; i++) // 3개의 ItemBox를 모두 확인
        {
            if (itemBoxes[i].isOveraped) count++; // 만약 ItemBox가 충돌했다면 count를 1 증가
        }

        if(count >= 3) // 만약 충돌한 ItemBox의 개수가 3개 이상이라면
        {
            Debug.Log("게임 승리"); 
            winUI.SetActive(true); // 게임 승리 UI 활성화
            isGameover = true; // 게임 오버 상태를 게임 승리로 변경
        }
    }
}
