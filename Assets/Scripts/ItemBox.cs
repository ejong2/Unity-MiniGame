using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false; // 아이템 박스와 충돌했는지 여부를 저장할 변수

    private Renderer myRenderer; // ItemBox의 Renderer 컴포넌트를 참조
    public Color touchColor;     // 충돌시 바뀔 색을 참조할 변수

    void Start()
    {
        myRenderer = GetComponent<Renderer>(); // Renderer 컴포넌트를 가져옴
    }

    void Update()
    {
    }

    // 트리거 콜라이더와 충돌했을 때 자동으로 실행
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndPoint")            // 태그가 "EndPoint"일 경우
        {
            isOveraped = true;                  // isOveraped를 true로 변경
            myRenderer.material.color = touchColor; // 색을 touchColor로 변경
        }
    }

    // 트리거 콜라이더와 충돌이 끝났을 때 자동으로 실행
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")            // 태그가 "EndPoint"일 경우
        {
            isOveraped = false;                 // isOveraped를 false로 변경
            myRenderer.material.color = Color.white; // 색을 흰색으로 변경
        }
    }

    // 트리거 콜라이더와 충돌하고 있는 동안 계속 실행
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")            // 태그가 "EndPoint"일 경우
        {
            isOveraped = true;                  // isOveraped를 true로 변경
            myRenderer.material.color = touchColor; // 색을 touchColor로 변경
        }
    }
}