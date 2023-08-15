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

    // Ʈ���� �ݶ��̴��� �浹���� �� �ڵ����� ����
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            myRenderer.material.color = touchColor;
            Debug.Log("�浹");
        }
    }

    // Ʈ���� �ݶ��̴��� �浹�� ������ �� �ڵ����� ����
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            myRenderer.material.color = Color.white;
            Debug.Log("�浹 ����");
        }
    }
}


