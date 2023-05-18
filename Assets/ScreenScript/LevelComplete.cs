using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : screen
{
    public Text displayscoretxt;
    void Start()
    {
        Spawner.inst.OnDisablePlay();
        //Audio.inst.SoundPlay(Audio.SoundName.GameComplete);

    }
    private void Update()
    {
        displayscoretxt.text = Score.inst.scoretxt.text;

    }

    public void OnHomeButton()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
    }
}
