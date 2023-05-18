using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BScoreGame1 : MonoBehaviour
{
    public static BScoreGame1 inst;
    public int ballscore = 10;
    public Text ballscoretxt;

    private void Awake()
    {
        inst = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("scoreobs"))
        {
            ballscore = ballscore - 1;
            ballscoretxt.text = ballscore.ToString();

        }

    }

}
