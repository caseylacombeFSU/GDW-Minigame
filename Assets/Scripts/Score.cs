using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    private int barrierScore = 0;
    private int ballScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Barrier Score: " + 0
                     + "\nBall Score: " + 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScore(int points, int type)
    {
        if (type > 0)
        {
            ballScore += points;
            scoreText.text = "Barrier Score: " + barrierScore.ToString() + 
                           "\nBall Score: " + ballScore.ToString();
        }
        else
        {
            barrierScore += points;
            scoreText.text = "Barrier Score: " + barrierScore.ToString() +
                           "\nBall Score: " + ballScore.ToString();
        }
    }

}
