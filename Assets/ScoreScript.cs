using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        if (scoreValue <= 6)
        {
            score.text = "Score : " + scoreValue;
        }
        else
        {
            score.text = "Score : DUMB";
        }
    }
}
