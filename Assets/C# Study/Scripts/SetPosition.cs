using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0, 0, 0); // (0, 0, 0) 위치로 이동
        transform.localPosition = new Vector3(0, 0, 0); // (0, 0, 0) 위치로 이동

    }
}
