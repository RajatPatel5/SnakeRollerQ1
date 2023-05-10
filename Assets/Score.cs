using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text scoretxt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score = score + 10;
        scoretxt.text = score.ToString();
    }



}
