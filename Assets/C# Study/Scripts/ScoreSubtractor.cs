using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSubtractor : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Score: " + ScoreManager.GetInstance().GetScore());
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            ScoreManager.GetInstance().AddScore(-2);
            Debug.Log("Score: " + ScoreManager.GetInstance().GetScore());
        }
    }
}
