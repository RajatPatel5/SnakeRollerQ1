using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : screen
{
    public Text displayscoretxt;
    void Start()
    {
        //Spawner.inst.OnDisablePlay();
        Audio.inst.SoundPlay(Audio.SoundName.GameComplete);
        //displayscoretxt.text = Score.inst.scoretxt.text;

    }
    public void Update()
    {


    }

    public void OnHomeButton()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
    }
    public void NextBtn()
    {
        Spawner.inst.Onreset();
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Debug.Log("changeui");
        LevelManager.inst.NextButton();

    }


}
