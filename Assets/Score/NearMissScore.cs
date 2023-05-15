using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NearMissScore : MonoBehaviour
{
    public int point = 0;
    public Text naertxt;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        point = point + 20;
        naertxt.text = point.ToString();
    }

}
