using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class ImageFade : MonoBehaviour
{
    public GameObject chooseObject;
    public GameObject thisTask;
    [SerializeField] float testnum = 0f;
    [SerializeField] float othernum = .9f;



    // the image you want to fade, assign in inspector
    public Image img;
    public float Fade()
    {
        // fades the image out when you enter
        StartCoroutine(FadeImage(true));
        return testnum;

    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {// loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(0, 0, 0, i);
                testnum = i;
                yield return testnum;
            }
            
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                testnum = i;
                yield return testnum;
            }
        }
    }
}