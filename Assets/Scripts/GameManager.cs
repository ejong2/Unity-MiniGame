using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ItemBox[] itemBoxes; // ItemBox �迭 ����
    public Boolean isGameover = false; // ���� ���� ���� ����
    void Start()
    {
        isGameover = false; // ���� ���� ���¸� ���� ������ ����
    }

    void Update()
    {
        if (isGameover) return; // ���� ���� ���¶�� ������Ʈ�� �������� ����
        
        int count = 0; // ItemBox �߿��� �浹�� ItemBox�� ������ ������ ����
        for(int i = 0; i < 3; i++) // 3���� ItemBox�� ��� Ȯ��
        {
            if (itemBoxes[i].isOveraped) // ���� ItemBox�� isOveraped�� true���
            {
                count++; // count�� 1 ����
            }
        }

        if(count >= 3) // ���� �浹�� ItemBox�� ������ 3�� �̻��̶��
        {
            Debug.Log("���� �¸�"); 
            isGameover = true; // ���� ���� ���¸� ���� �¸��� ����
        }
    }
}
