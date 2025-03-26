using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFade : MonoBehaviour
{
    [SerializeField] Color targetColor;
    [SerializeField] Image fadeImage;
    [SerializeField] float fadeSpeed;
    float progress = 0;
    Color currentColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ImageFade()
    {
        currentColor = Color.red;
        fadeImage.color = currentColor;
        Debug.Log("ImageFade Function Called");

    }

    // Update is called once per frame
    void Update()
    {

        currentColor = Color.Lerp(currentColor, targetColor, fadeSpeed * Time.deltaTime);

        fadeImage.color = currentColor;
        /*var currentColor = fadeImage.color;
        progress += Time.deltaTime * fadeSpeed;
        currentColor = Color.Lerp(currentColor, targetColor, progress);*/
    }
}
