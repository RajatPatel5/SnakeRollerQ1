using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BScoreGame2 : MonoBehaviour
{
    public static BScoreGame2 inst;
    public int ballscore = 20;
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
