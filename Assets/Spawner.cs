using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject ball;
    public Action OnAction;
    public Action OnStartAction;
    public static Spawner inst;

    private void Awake()
    {
        inst = this;
    }
    private void Start()
    {
        OnStartBallPlay();
    }

    private void Update()
    {
        OnAction?.Invoke();
    }

    public void StartBallSpawn()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
    public void BallSpawn()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (BallScore.inst.ballscore == 0)
            {
                return;
            }
            Instantiate(ball, transform.position, transform.rotation);

        }

    }

    public void OnEnablePlay()
    {
        OnAction += BallSpawn;
    }
    public void OnDisablePlay()
    {
        OnAction -= BallSpawn;
        OnAction -= StartBallSpawn;
    }
    public void OnStartBallPlay()
    {
        OnStartAction += StartBallSpawn;
    }

}




