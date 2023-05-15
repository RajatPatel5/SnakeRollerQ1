using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score inst;
    public int score = 0;
    public Text scoretxt;

    private void Awake()
    {
        inst = this;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        score = score + 10;
        scoretxt.text = score.ToString();
    }



}
