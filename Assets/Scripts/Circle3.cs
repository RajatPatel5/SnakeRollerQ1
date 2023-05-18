using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle3 : MonoBehaviour
{
    public float speed;
    public List<GameObject> rings;
    //public GameObject innercircle;
    //public GameObject outercircle;
    public static Circle3 inst;



    private void Start()
    {
        Timer();
        inst = this;
    }

    void Update()
    {

        for (int i = 0; i < rings.Count; i++)
        {
            if (i % 2 == 0)
            {
                rings[i].transform.Rotate(0f, 0f, speed * Time.deltaTime);
                Debug.Log("even rotate");

            }
            else
            {
                rings[i].transform.Rotate(0f, 0f, -speed * Time.deltaTime);
                Debug.Log("odd rotate");

            }
        }

        //innercircle.transform.Rotate(0f, 0f, speed * Time.deltaTime);
        //outercircle.transform.Rotate(0f, 0f, -speed * Time.deltaTime);
    }
    public void Timer()
    {
        Invoke("Timer", 5);
        speed = Random.Range(-200, 300);
        Debug.Log(speed);

    }
}
