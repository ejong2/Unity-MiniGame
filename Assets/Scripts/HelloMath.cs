using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMath : MonoBehaviour
{
    void Start()
    {
        int a = 5;
        int b = 7;
        int sum = a + b;
        Debug.Log($"гу: {sum}");

        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a / b);
        Debug.Log(a % b);

        int i = 0;
        i = i + 1;
        Debug.Log(i);

        i++;
        Debug.Log(i);
    }

    void Update()
    {
        
    }
}
