using System;
using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    public static LevelTimer Instance;

    private float startTime;
    private float pausedTime;
    private float levelDuration;
    private bool isTiming;
    private bool isPaused;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void StartTimer()
    {
        startTime = Time.time;
        pausedTime = 0f;
        isTiming = true;
        isPaused = false;
    }

    public void PauseTimer()
    {
        if (isTiming && !isPaused)
        {
            pausedTime = Time.time;
            isPaused = true;
        }
    }

    public void ResumeTimer()
    {
        if (isTiming && isPaused)
        {
            float pauseDuration = Time.time - pausedTime;
            startTime += pauseDuration; // shift startTime forward to exclude pause
            isPaused = false;
        }
    }

    public void StopTimer()
    {
        if (isTiming)
        {
            levelDuration = (isPaused ? pausedTime : Time.time) - startTime;
            isTiming = false;
            isPaused = false;

            Debug.Log("Level completed in: " + levelDuration + " seconds");

            if (PlayerPrefs.GetFloat("LevelTime_" + LevelController.currentLevel, 1) == 1)
            {
                PlayerPrefs.SetFloat("LevelTime_" + LevelController.currentLevel, levelDuration);
                PlayerPrefs.Save();
            }
        }
    }

    public float GetLevelDuration()
    {
        return levelDuration;
    }

    public float GetCurrentElapsedTime()
    {
        if (!isTiming)
            return levelDuration;

        return (isPaused ? pausedTime : Time.time) - startTime;
    }
}
