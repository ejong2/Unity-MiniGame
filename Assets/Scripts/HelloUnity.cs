using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity!");

        // 정수형 변수
        int age = 23;
        int money = -1000;

        Debug.Log("나이: " + age);
        Debug.Log("돈: " + money);

        // 실수형 변수 (소수점 아래 7자리까지만 정확)
        float height = 178.5f;
        float weight = 75.5f;

        Debug.Log("키: " + height);
        Debug.Log("몸무게: " + weight);

        // float의 두배 메모리를 사용 64비트 (소수점 아래 15자리까지만 정확)
        double pi = 3.14159265358979323846264338;
        Debug.Log("원주율: " + pi);

        // 논리형 변수
        bool isMarried = false;
        Debug.Log("결혼 여부: " + isMarried);

        // 문자열 변수
        string name = "홍길동";
        Debug.Log("이름: " + name);

        // 문자열 결합
        Debug.Log("이름: " + name + ", 나이: " + age + ", 결혼 여부: " + isMarried);

        // 문자열 보간
        Debug.Log($"이름: {name}, 나이: {age}, 결혼 여부: {isMarried}");

        // 문자열 길이
        Debug.Log($"이름의 길이: {name.Length}");

        // 문자열 자르기
        Debug.Log($"이름의 첫 글자: {name[0]}");

        // 문자열 찾기
        Debug.Log($"이름에 '길동'이 포함되어 있는가? {name.Contains("길동")}");

        // 문자열 바꾸기
        Debug.Log($"이름을 '임꺽정'으로 바꾸기: {name.Replace("홍길동", "임꺽정")}");

        // 문자열 대문자로 바꾸기
        Debug.Log($"이름을 대문자로 바꾸기: {name.ToUpper()}");

        // var 키워드 (자료형을 자동으로 추론)
        var myName = "홍길동";
        var myAge = 23;
        var myIsMarried = false;

        Debug.Log($"이름: {myName}, 나이: {myAge}, 결혼 여부: {myIsMarried}");

    }

    void Update()
    {
        
    }
}
