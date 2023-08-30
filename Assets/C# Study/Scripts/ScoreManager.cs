using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public List<int> scores = new List<int>();

    private void Start()
    {
        int score0 = 45;
        int score1 = 100;
        int score2 = 30;

        scores.Add(score0);
        scores.Add(score1);
        scores.Add(score2);

        Debug.Log("scores[0] = " + scores[0]);
        Debug.Log("scores[1] = " + scores[1]);
        Debug.Log("scores[2] = " + scores[2]);
    }

}
