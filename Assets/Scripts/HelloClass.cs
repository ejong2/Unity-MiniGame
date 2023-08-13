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

public class Animal // 클래스
{
    // 필드
    public string name;
    public int age;

    // 생성자
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // 메서드
    public void Print()
    {
        Debug.Log($"name: {name}, age: {age}");
    }
}
