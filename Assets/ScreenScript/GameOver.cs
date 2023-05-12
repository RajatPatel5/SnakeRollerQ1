using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : screen
{
    public Text displayscoretxt;

    private void Update()
    {
        displayscoretxt.text = Score.inst.scoretxt.text;
    }
    public void Try()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Spawner.inst.OnEnablePlay();
    }

}
