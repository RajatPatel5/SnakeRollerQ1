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
    public List<Ball> balls = new List<Ball>();

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
        Debug.LogWarning("BALL SPAWBIBG");

        if (Input.GetMouseButtonDown(0))
        {
            Ball ballobj = Instantiate(ball, transform.position, transform.rotation).GetComponent<Ball>();
            Debug.Log("ball spawn");
            Audio.inst.SoundPlay(Audio.SoundName.Shoot);
            balls.Add(ballobj);
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
        if (BScoreGame1.inst.ballscore == 0)
        {
            OnAction = null;
            UIManager.inst.ShowNextScreen(ScreenEnum.LevelComplete);
            return;
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

    public void Onreset()
    {
        for (int i = 0; i < balls.Count; i++)
        {
            Destroy(balls[i].gameObject);
        }
        balls.Clear();
    }

}




