using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloClass : MonoBehaviour
{
    void Start()
    {
        Console.WriteLine("Welcome to C# Programming!");
    }

    void Update()
    {
        
    }
}

public class Animal // Ŭ����
{
    // �ʵ�
    public string name;
    public int age;

    // ������
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // �޼���
    public void Print()
    {
        Debug.Log($"name: {name}, age: {age}");
    }
}
