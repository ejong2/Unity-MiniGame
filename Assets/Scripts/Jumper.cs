using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Vector3.up * 500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
