using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : screen
{

    public void OnPlayButton()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Spawner.inst.OnEnablePlay();
        Spawner.inst.OnStartBallPlay();

    }

}
