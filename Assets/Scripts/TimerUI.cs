using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public TMP_Text timerText;
    private string lastTimeText = "";
    private Vector3 originalScale;
    private float animationDuration = 0.2f;
    private float animationTime = 0f;
    private bool isAnimating = false;

    void Start()
    {
        originalScale = timerText.transform.localScale;
    }

    void Update()
    {
        if (LevelTimer.Instance != null)
        {
            float seconds = LevelTimer.Instance.GetCurrentElapsedTime();
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            string currentText = string.Format("{0:00}:{1:00}", timeSpan.Minutes, timeSpan.Seconds);

            // Only update if the text changes
            if (currentText != lastTimeText)
            {
                lastTimeText = currentText;
                timerText.text = currentText;
                AnimatePop();
            }

            // Animate scale pop
            if (isAnimating)
            {
                animationTime += Time.deltaTime;
                float progress = animationTime / animationDuration;
                float scale = Mathf.Lerp(1.2f, 1f, progress);
                timerText.transform.localScale = originalScale * scale;

                if (progress >= 1f)
                {
                    isAnimating = false;
                    timerText.transform.localScale = originalScale;
                }
            }
        }
    }

    void AnimatePop()
    {
        animationTime = 0f;
        isAnimating = true;
        timerText.transform.localScale = originalScale * 1.2f; // Start bigger
    }
}
