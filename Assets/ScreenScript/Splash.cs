using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Splash : screen
{
    public Image image;
    public bool fade;
    public float TimeToFade;
    Graphics graphics;
    Color color;

    private void Start()
    {
        image = GetComponent<Image>();


        UIManager.inst.ShowNextScreen(ScreenEnum.Splash);
        Spawner.inst.OnDisablePlay();

        StartCoroutine(EnableMainMenu());
        IEnumerator EnableMainMenu()
        {
            yield return new WaitForSeconds(2);
            UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        }
    }
    private void Update()
    {
        if (fade)
        {
            if (image.color.a >= 0)
            {
                fade = true;
                if (image.color.a == 0)
                {
                    fade = false;
                }
            }
        }
    }

}
