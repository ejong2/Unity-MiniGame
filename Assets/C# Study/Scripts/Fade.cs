using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image fadeImage;

    private void Start()
    {
        FadeIn();
    }

    void FadeIn()
    {
        StartCoroutine(FadeInCoroutine());
        //StartCoroutine("FadeOutCoroutine");
    }

    IEnumerator FadeInCoroutine()
    {
        Color startColor = fadeImage.color;

        for (int i = 0; i < 100; i++)
        {
            startColor.a -= 0.01f;
            fadeImage.color = startColor;
            yield return new WaitForSeconds(0.01f);
        }
    }


}
