using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

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


    public void BallSpawn()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ball, transform.position, transform.rotation);
            Debug.Log("ball spawn");
            Audio.inst.SoundPlay(Audio.SoundName.Shoot);

            //if (BScoreGame1.inst.ballscore == 0)
            //{
            //    UIManager.inst.ShowNextScreen(ScreenEnum.LevelComplete);
            //    return;
            //}
            //else if (BScoreGame2.inst.ballscore == 0)
            //{
            //    UIManager.inst.ShowNextScreen(ScreenEnum.LevelComplete);
            //    return;
            //}
            //else if (BScoreGame3.inst.ballscore == 0)
            //{
            //    UIManager.inst.ShowNextScreen(ScreenEnum.LevelComplete);
            //    return;
            //}

        }

    }

    public void OnEnablePlay()
    {
        OnAction += BallSpawn;

    }
    public void OnDisablePlay()
    {
        OnAction -= BallSpawn;

    }

}




