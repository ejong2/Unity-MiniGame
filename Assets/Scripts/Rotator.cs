using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        // 1�ʿ� 60�� ȸ��
        transform.Rotate(new Vector3(60f, 60f, 60f) * Time.deltaTime);
    }
}
