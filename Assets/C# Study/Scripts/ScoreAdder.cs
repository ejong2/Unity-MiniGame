using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Score: " + ScoreManager.GetInstance().GetScore());
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ScoreManager.GetInstance().AddScore(5);
            Debug.Log("Score: " + ScoreManager.GetInstance().GetScore());
        }
    }
}
