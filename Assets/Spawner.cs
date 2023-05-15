using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject ball;
    public Action OnAction;
    public static Spawner inst;

    private void Awake()
    {
        inst = this;
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
                UIManager.inst.ShowNextScreen(ScreenEnum.LevelComplete);
                return;
            }
            Instantiate(ball, transform.position, transform.rotation);
            Audio.inst.SoundPlay(Audio.SoundName.Shoot);

        }

    }

    public void OnEnablePlay()
    {
        OnAction += BallSpawn;

        // OnAction += Circle.inst.Timer;
    }
    public void OnDisablePlay()
    {
        OnAction -= BallSpawn;
        // OnAction -= Circle.inst.Timer;
    }


}




