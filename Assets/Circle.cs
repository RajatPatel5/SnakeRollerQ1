using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float speed;
    public GameObject innercircle;
    public GameObject outercircle;
    public static Circle inst;
    private void Start()
    {
        Timer();
        inst = this;
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
