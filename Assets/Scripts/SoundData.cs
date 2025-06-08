using UnityEngine;

[CreateAssetMenu(fileName = "SoundData", menuName = "Audio/Sound Data")]
public class SoundData : ScriptableObject
{
    public AudioClip buttonClick;
    public AudioClip diffClick;
    public AudioClip levelCompleted;

    public AudioClip gameOver;
    public AudioClip wrongClick;
    public Sprite soundOnSprite;
    public Sprite soundOffSprite;
}
