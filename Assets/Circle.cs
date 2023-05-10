using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float speed;
    public GameObject innercircle;
    public GameObject outercircle;
    private void Start()
    {
        Timer();
    }

    void Update()
    {

        innercircle.transform.Rotate(0f, 0f, speed * Time.deltaTime);
        outercircle.transform.Rotate(0f, 0f, -speed * Time.deltaTime);
    }
    public void Timer()
    {
        Invoke("Timer", 5);
        speed = Random.Range(-50, 200);
        Debug.Log(speed);

    }

}
