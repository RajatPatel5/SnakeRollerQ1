using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject ball;
    public void Start()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ball, transform.position, transform.rotation);
        }

    }
}
