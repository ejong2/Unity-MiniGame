using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Overloading");

        Debug.Log("Sum(1, 2) = " + Sum(1, 2));
        Debug.Log("Sum(1, 2, 3) = " + Sum(1, 2, 3));
        Debug.Log("Sum(1.5f, 2.5f) = " + Sum(1.5f, 2.5f));
        Debug.Log("Sum(1.5f, 2.5f, 3.5f) = " + Sum(1.5f, 2.5f, 3.5f));
    }

    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    public float Sum(float a, float b)
    {
        return a + b;
    }

    public float Sum(float a, float b, float c)
    {
        return a + b + c;
    }

}
