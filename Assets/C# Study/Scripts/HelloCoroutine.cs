using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("HelloUnity");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine("HelloUnity");
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine("HelloUnity");
        }
    }

    IEnumerator HelloUnity()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Hello Unity");
        }
    }
}
