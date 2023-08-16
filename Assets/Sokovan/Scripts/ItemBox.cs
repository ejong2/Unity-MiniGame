using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false; // ������ �ڽ��� �浹�ߴ��� ���θ� ������ ����

    private Renderer myRenderer; // ItemBox�� Renderer ������Ʈ�� ����
    public Color touchColor;     // �浹�� �ٲ� ���� ������ ����

    void Start()
    {
        myRenderer = GetComponent<Renderer>(); // Renderer ������Ʈ�� ������
    }

    void Update()
    {
    }

    // Ʈ���� �ݶ��̴��� �浹���� �� �ڵ����� ����
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndPoint")            // �±װ� "EndPoint"�� ���
        {
            isOveraped = true;                  // isOveraped�� true�� ����
            myRenderer.material.color = touchColor; // ���� touchColor�� ����
        }
    }

    // Ʈ���� �ݶ��̴��� �浹�� ������ �� �ڵ����� ����
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")            // �±װ� "EndPoint"�� ���
        {
            isOveraped = false;                 // isOveraped�� false�� ����
            myRenderer.material.color = Color.white; // ���� ������� ����
        }
    }

    // Ʈ���� �ݶ��̴��� �浹�ϰ� �ִ� ���� ��� ����
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")            // �±װ� "EndPoint"�� ���
        {
            isOveraped = true;                  // isOveraped�� true�� ����
            myRenderer.material.color = touchColor; // ���� touchColor�� ����
        }
    }
}