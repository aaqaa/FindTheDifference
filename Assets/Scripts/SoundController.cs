
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource), typeof(Image))]
public class SoundController : MonoBehaviour, IPointerClickHandler
{
    public static SoundController Instance;

    public SoundData soundData; // Assign GlobalSoundData in Inspector
    private bool isSoundOn = true;

    private AudioSource audioSource;
    private Image soundButtonImage;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        audioSource = GetComponent<AudioSource>();
        soundButtonImage = GetComponent<Image>();
        isSoundOn =  GameProgress.GetSoundOn() ==1 ? true : false;
        soundButtonImage.sprite = isSoundOn ? soundData.soundOnSprite : soundData.soundOffSprite;

    }

    void Start()
    {
        soundButtonImage.sprite = soundData.soundOnSprite;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isSoundOn = !isSoundOn;
        GameProgress.SaveSoundOn(isSoundOn ? 1:0);
        soundButtonImage.sprite = isSoundOn ? soundData.soundOnSprite : soundData.soundOffSprite;

        if (isSoundOn)
            PlayButtonClickSound();
    }

    public void PlayButtonClickSound()
    {
        if (isSoundOn)
            StartCoroutine(PlaySound(soundData.buttonClick));
    }

    public void PlayDiffClickSound()
    {
        if (isSoundOn)
            StartCoroutine(PlaySound(soundData.diffClick));
    }

    public void PlayLevelCompletedSound()
    {
        if (isSoundOn)
            StartCoroutine(PlaySound(soundData.levelCompleted));
    }
    public void PlayGameOverSound()
    {
        if (isSoundOn)
            StartCoroutine(PlaySound(soundData.gameOver));
    }

    public void PlayWrongClickSound()
    {
        if (isSoundOn)
            StartCoroutine(PlaySound(soundData.wrongClick));
    }

    private IEnumerator PlaySound(AudioClip clip)
    {
        yield return null;
        if (clip != null)
            audioSource.PlayOneShot(clip);
    }
}

