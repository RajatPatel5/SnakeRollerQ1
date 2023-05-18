using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : screen
{
    public GameObject SettingPanel;
    public void Start()
    {
        SettingPanel.SetActive(false);
        //Audio.inst.BackgroundMusic(Audio.SoundName.Mainmenu);
    }
    public void OnPlayButton()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        Spawner.inst.OnEnablePlay();
        Audio.inst.BackgroundMusic(Audio.SoundName.Background);

    }

    public void OnSettingButton()
    {
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        SettingPanel.SetActive(true);
    }
    public void OnBackButton()
    {
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        SettingPanel.SetActive(false);
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);

    }
    public void OnSaveButton()
    {
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        SettingPanel.SetActive(false);
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
    }
    public void OnDefaultButtton()
    {
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        SettingPanel.SetActive(false);
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Seting.inst.soundslider.value = 1;
        Seting.inst.bgsoundslider.value = 1;

    }


}
