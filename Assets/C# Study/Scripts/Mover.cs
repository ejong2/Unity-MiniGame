using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 move = new Vector3(-5, 5, -5); // 이동할 거리

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        { 
            Move();
        }

    }

    void Move()
    {
        transform.Translate(move * Time.deltaTime);
    }
}
