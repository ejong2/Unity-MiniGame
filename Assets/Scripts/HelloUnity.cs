using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity!");

        // ������ ����
        int age = 23;
        int money = -1000;

        Debug.Log("����: " + age);
        Debug.Log("��: " + money);

        // �Ǽ��� ���� (�Ҽ��� �Ʒ� 7�ڸ������� ��Ȯ)
        float height = 178.5f;
        float weight = 75.5f;

        Debug.Log("Ű: " + height);
        Debug.Log("������: " + weight);

        // float�� �ι� �޸𸮸� ��� 64��Ʈ (�Ҽ��� �Ʒ� 15�ڸ������� ��Ȯ)
        double pi = 3.14159265358979323846264338;
        Debug.Log("������: " + pi);

        // ���� ����
        bool isMarried = false;
        Debug.Log("��ȥ ����: " + isMarried);

        // ���ڿ� ����
        string name = "ȫ�浿";
        Debug.Log("�̸�: " + name);

        // ���ڿ� ����
        Debug.Log("�̸�: " + name + ", ����: " + age + ", ��ȥ ����: " + isMarried);

        // ���ڿ� ����
        Debug.Log($"�̸�: {name}, ����: {age}, ��ȥ ����: {isMarried}");

        // ���ڿ� ����
        Debug.Log($"�̸��� ����: {name.Length}");

        // ���ڿ� �ڸ���
        Debug.Log($"�̸��� ù ����: {name[0]}");

        // ���ڿ� ã��
        Debug.Log($"�̸��� '�浿'�� ���ԵǾ� �ִ°�? {name.Contains("�浿")}");

        // ���ڿ� �ٲٱ�
        Debug.Log($"�̸��� '�Ӳ���'���� �ٲٱ�: {name.Replace("ȫ�浿", "�Ӳ���")}");

        // ���ڿ� �빮�ڷ� �ٲٱ�
        Debug.Log($"�̸��� �빮�ڷ� �ٲٱ�: {name.ToUpper()}");

        // var Ű���� (�ڷ����� �ڵ����� �߷�)
        var myName = "ȫ�浿";
        var myAge = 23;
        var myIsMarried = false;

        Debug.Log($"�̸�: {myName}, ����: {myAge}, ��ȥ ����: {myIsMarried}");

    }

    void Update()
    {
        
    }
}
