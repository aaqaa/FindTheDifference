using System;
using UnityEngine;

public static class GameProgress 
{
    private const string LEVEL_KEY = "CurrentLevel";
    private const string LEVEL_TIMER_KEY = "LevelTime_";

    private const string SOUND_ON = "SoundOn";    
    public static void SaveLevel(int level)
    {
        PlayerPrefs.SetInt(LEVEL_KEY, level);
        PlayerPrefs.Save();
        
    }

    public static int LoadLevel()
    {
        return PlayerPrefs.GetInt(LEVEL_KEY, 1);
    }

    public static void ResetProgress()
    {
        PlayerPrefs.DeleteKey(LEVEL_KEY);
        PlayerPrefs.DeleteKey(LEVEL_TIMER_KEY);
    }

      public static string GetTimerValue(int level)
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(PlayerPrefs.GetFloat(LEVEL_TIMER_KEY+level, 0));
        return string.Format("{0:00}:{1:00}", timeSpan.Minutes, timeSpan.Seconds);
    }

    public static void SaveSoundOn(int soundOn)
    {
        PlayerPrefs.SetInt(SOUND_ON, soundOn);
        PlayerPrefs.Save();   
    }
public static int GetSoundOn()
    {
       return PlayerPrefs.GetInt(SOUND_ON, 1);
    }
public static void ResetSoundOn()
    {
        PlayerPrefs.DeleteKey(SOUND_ON);
    }

}
