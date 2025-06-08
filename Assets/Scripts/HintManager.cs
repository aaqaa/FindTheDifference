using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintManager : MonoBehaviour
{
    public GameObject hintEffectPrefab;
    private GameObject currentHintEffect;
    public Sprite newSprite;         // Sprite to fade into
    public Image imageTarget;
    private bool disableHintBtn;
    private List<DifferenceSpot> allDifferences;
    public float fadeDuration = 1f;  // Duration of the fade

    private Image overlayImage;
    void Start()
    {
        allDifferences = new List<DifferenceSpot>(FindObjectsByType<DifferenceSpot>(FindObjectsSortMode.None));
    }

    public void ShowHint()
    {
        if(!disableHintBtn){
        disableHintBtn = true;
        SoundController.Instance.PlayButtonClickSound();    
        // imageTarget.sprite = hintDisabledSprite;
        foreach (var diff in allDifferences)
        {
            if (!diff.found)
            {
                if (currentHintEffect != null)
                    Destroy(currentHintEffect); // optional safeguard

                currentHintEffect = Instantiate(hintEffectPrefab, diff.transform.position, Quaternion.identity);
                currentHintEffect.transform.localScale = diff.transform.localScale;
                break;
            }
        }
        StartCoroutine(FadeSprite());
        }
     
    }


    private IEnumerator FadeSprite()
    {
        imageTarget.color = new Color(1, 1, 1, 0); // Start fully transparent
        imageTarget.sprite = newSprite;

        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            float alpha = t / fadeDuration;
            imageTarget.color = new Color(1, 1, 1, alpha);
            yield return null;
        }

        imageTarget.color = new Color(1, 1, 1, 1); // Ensure fully visible
        disableHintBtn = false;
    }
    //  IEnumerator FadeToSprite()
    // {
    //     // Create a temporary overlay Image
    //     GameObject overlay = new GameObject("Overlay");
    //     overlay.transform.SetParent(imageTarget.transform.parent);
    //     overlay.transform.SetSiblingIndex(imageTarget.transform.GetSiblingIndex() + 1);

    //     overlayImage = overlay.AddComponent<Image>();
    //     overlayImage.sprite = newSprite;
    //     overlayImage.rectTransform.sizeDelta = imageTarget.rectTransform.sizeDelta;
    //     overlayImage.rectTransform.position = imageTarget.rectTransform.position;
    //     overlayImage.rectTransform.localScale = Vector3.one;

    //     Color overlayColor = overlayImage.color;
    //     overlayColor.a = 0f;
    //     overlayImage.color = overlayColor;

    //     float elapsed = 0f;

    //     while (elapsed < fadeDuration)
    //     {
    //         elapsed += Time.deltaTime;
    //         float t = Mathf.Clamp01(elapsed / fadeDuration);
    //         overlayColor.a = t;
    //         overlayImage.color = overlayColor;
    //         yield return null;
    //     }

    //     // Finalize
    //     imageTarget.sprite = newSprite;
    //     disableHintBtn = false;
    //     Destroy(overlay);
    // }
}
