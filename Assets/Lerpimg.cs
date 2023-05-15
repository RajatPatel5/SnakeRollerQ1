using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Lerpimg : MonoBehaviour
{
    float time = 0;
    public Image image;

    void Start()
    {
        StartCoroutine(Lerp());

    }

    IEnumerator Lerp()
    {
        var alpha = image.color.a;
        while (alpha > 0f)
        {
            var newColor = new Color(0f, 0f, 0f, Mathf.Lerp(255, 0, time));
            image.color = newColor;
            yield return image.color;
        }

    }


}
