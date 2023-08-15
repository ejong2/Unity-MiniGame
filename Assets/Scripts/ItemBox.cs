using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private Renderer myRenderer;
    public Color touchColor;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        
    }

    // 트리거 콜라이더와 충돌했을 때 자동으로 실행
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            myRenderer.material.color = touchColor;
            Debug.Log("충돌");
        }
    }

    // 트리거 콜라이더와 충돌이 끝났을 때 자동으로 실행
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            myRenderer.material.color = Color.white;
            Debug.Log("충돌 해제");
        }
    }
}


