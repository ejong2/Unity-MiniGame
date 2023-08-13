using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArray : MonoBehaviour
{
    void Start()
    {
        int score1 = 10;
        int score2 = 20;
        int score3 = 30;

        Debug.Log($"score1: {score1}");
        Debug.Log($"score2: {score2}");
        Debug.Log($"score3: {score3}");

        // 배열
        int[] scores = new int[3];
        scores[0] = 10;
        scores[1] = 20;
        scores[2] = 30;

        Debug.Log($"scores[0]: {scores[0]}");
        Debug.Log($"scores[1]: {scores[1]}");
        Debug.Log($"scores[2]: {scores[2]}");

        // 배열의 길이
        Debug.Log($"scores.Length: {scores.Length}");

        // 배열의 선언과 초기화
        int[] scores2 = new int[] { 10, 20, 30 };
        int[] scores3 = { 10, 20, 30 };
        scores2[0] = 10;
        scores2[1] = 20;
        scores2[2] = 30;
        scores2[3] = 30;

        // 배열의 반복문
        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log($"scores[{i}]: {scores[i]}");
        }

        // 배열의 반복문 foreach
        foreach (int score in scores)
        {
            Debug.Log($"score: {score}");
        }

        // 배열의 초기화
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = 0;
        }
    }

    void Update()
    {
        
    }
}
