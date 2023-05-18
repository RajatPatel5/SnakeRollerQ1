using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : screen
{
    public Text displayscoretxt;

    private void Start()
    {
        Spawner.inst.OnDisablePlay();
        //Audio.inst.SoundStop();

    }
    private void Update()
    {
        displayscoretxt.text = Score.inst.scoretxt.text;

    }
    public void Try()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Audio.inst.SoundPlay(Audio.SoundName.Try);
        Spawner.inst.OnEnablePlay();
    }
    public void OnHomeButton()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
    }

}
