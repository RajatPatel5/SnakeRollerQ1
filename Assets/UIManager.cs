using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager inst;
    public List<screen> screenList;
    public screen currentScreen;

    private void Awake()
    {
        inst = this;
        currentScreen = screenList[0];
    }

    public void ShowNextScreen(ScreenEnum ScreenType)
    {
        if (currentScreen != null)
            currentScreen.HideScreen();

        screenList[(int)ScreenType].ShowScreen();
        currentScreen = screenList[(int)ScreenType];
    }

}
