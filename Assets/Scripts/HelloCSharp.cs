using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp : MonoBehaviour
{
    void Start()
    {
        // ����ȯ ĳ���� 
        int height = 170;
        float heightDetail = 170.5f;

        heightDetail = height; // �Ͻ��� ����ȯ
        height = (int)heightDetail; // ����� ����ȯ

        Debug.Log($"Ű: {height}cm");
        Debug.Log($"Ű: {heightDetail}cm");

        // ���ǹ� 
        int age = 20;
        if (age >= 20)
        {
            Debug.Log("�����Դϴ�.");
        }
        else
        {
            Debug.Log("�̼������Դϴ�.");
        }

        // switch��
        int month = 8;

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Debug.Log("�ܿ��Դϴ�.");
                break;
            case 3:
            case 4:
            case 5:
                Debug.Log("���Դϴ�.");
                break;
            case 6:
            case 7:
            case 8:
                Debug.Log("�����Դϴ�.");
                break;
            case 9:
            case 10:
            case 11:
                Debug.Log("�����Դϴ�.");
                break;
            default:
                Debug.Log("�߸��� ���Դϴ�.");
                break;
        }

        // �ݺ���
        int count = 0;
        while (count < 10)
        {
            Debug.Log($"ī��Ʈ: {count}");
            count++;
        }

        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"ī��Ʈ: {i}");
        }

        do
        {
            Debug.Log($"ī��Ʈ: {count}");
            count++;
        } while (count < 10);

    }

    void Update()
    {
        
    }
}
