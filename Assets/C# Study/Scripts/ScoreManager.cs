using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.AI;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    public static ScoreManager GetInstance()
    {
        if (instance == null) instance = FindObjectOfType<ScoreManager>();
        if (instance == null) instance = new GameObject("ScoreManager").AddComponent<ScoreManager>();

        return instance;
    }

    private void Start()
    {
        // ScoreManager 중복 방지
        if (instance != null)
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    private int score = 0;
    public int GetScore() { return score; }
    public void AddScore(int newScore) { score += newScore; }
}
