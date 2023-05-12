using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : screen
{
    private void Changed()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GameOver);
    }
}
