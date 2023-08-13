using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp : MonoBehaviour
{
    void Start()
    {
        // 형변환 캐스팅 
        int height = 170;
        float heightDetail = 170.5f;

        heightDetail = height; // 암시적 형변환
        height = (int)heightDetail; // 명시적 형변환

        Debug.Log($"키: {height}cm");
        Debug.Log($"키: {heightDetail}cm");

        // 조건문 
        int age = 20;
        if (age >= 20)
        {
            Debug.Log("성인입니다.");
        }
        else
        {
            Debug.Log("미성년자입니다.");
        }

        // switch문
        int month = 8;

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Debug.Log("겨울입니다.");
                break;
            case 3:
            case 4:
            case 5:
                Debug.Log("봄입니다.");
                break;
            case 6:
            case 7:
            case 8:
                Debug.Log("여름입니다.");
                break;
            case 9:
            case 10:
            case 11:
                Debug.Log("가을입니다.");
                break;
            default:
                Debug.Log("잘못된 월입니다.");
                break;
        }

        // 반복문
        int count = 0;
        while (count < 10)
        {
            Debug.Log($"카운트: {count}");
            count++;
        }

        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"카운트: {i}");
        }

        do
        {
            Debug.Log($"카운트: {count}");
            count++;
        } while (count < 10);

    }

    void Update()
    {
        
    }
}
