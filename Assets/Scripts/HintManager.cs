using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class HintManager : MonoBehaviour
{
    public GameObject hintEffectPrefab;
    private GameObject currentHintEffect;
    public Sprite newSprite;         // Sprite to fade into
    public Image imageTarget;
    private bool disableHintBtn;
    private List<DifferenceSpot> allDifferences;
    public float fadeDuration = 10f;  // Duration of the fade

    void Start()
    {
        if (currentHintEffect != null)
        {
            Destroy(currentHintEffect);
         }
             
        // allDifferences = new List<DifferenceSpot>(FindObjectsByType<DifferenceSpot>(FindObjectsSortMode.None));
        allDifferences = FindObjectsByType<DifferenceSpot>(
                    FindObjectsInactive.Include,        // include inactive GOs
                    FindObjectsSortMode.None)
                  .Where(ds => ds.enabled && ds.gameObject.activeInHierarchy)
                  .ToList();
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
        imageTarget.color = new Color(1, 1, 1, 0.1f); // Start fully transparentp
        imageTarget.sprite = newSprite;

        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            // float alpha = t / fadeDuration;
            // if (alpha > 0.5f) { alpha = 0.5f; }
            // imageTarget.color = new Color(1, 1, 1,alpha);
            yield return null;
        }

        imageTarget.color = new Color(1, 1, 1, 1); // Ensure fully visible
        disableHintBtn = false;
    }
   
}
