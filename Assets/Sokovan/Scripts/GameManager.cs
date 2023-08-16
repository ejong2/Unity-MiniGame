using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winUI; // ���� �¸��� Ȱ��ȭ�� UI ���� ������Ʈ
    public ItemBox[] itemBoxes; // ItemBox �迭 ����
    public Boolean isGameover = false; // ���� ���� ���� ����
    void Start()
    {
        isGameover = false; // ���� ���� ���¸� ���� ������ ����
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene(0); // ���� �������� �ε�
            SceneManager.LoadScene("Sokovan/Scenes/Main"); // ���� �̸����� �ε�
        }

        if (isGameover) return; // ���� ���� ���¶�� ������Ʈ�� �������� ����
        
        int count = 0; // ItemBox �߿��� �浹�� ItemBox�� ������ ������ ����
        for(int i = 0; i < 3; i++) // 3���� ItemBox�� ��� Ȯ��
        {
            if (itemBoxes[i].isOveraped) count++; // ���� ItemBox�� �浹�ߴٸ� count�� 1 ����
        }

        if(count >= 3) // ���� �浹�� ItemBox�� ������ 3�� �̻��̶��
        {
            Debug.Log("���� �¸�"); 
            winUI.SetActive(true); // ���� �¸� UI Ȱ��ȭ
            isGameover = true; // ���� ���� ���¸� ���� �¸��� ����
        }
    }
}
