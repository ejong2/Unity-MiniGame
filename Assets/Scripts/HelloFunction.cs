using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFunction : MonoBehaviour
{
    void Start()
    {
        float diameter = 2.0f;
        float radius = GetRadius(diameter);
        Debug.Log($"¹ÝÁö¸§: {radius}");

        return;
    }

    void Update()
    {
        
    }

    float GetRadius(float diameter)
    {
        float pi = 3.14f;
        float tmp = diameter / pi;
        float radius = Mathf.Sqrt(tmp);
        return radius;
    }
}
