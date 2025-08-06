using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelMenu2 : MonoBehaviour
{
    [Header("UI References")]
    public Transform gridParent;
    public GameObject levelButtonPrefab;
    public ScrollRect scrollRect;

    [Header("Level Settings")]
    public string imagePrefix = "Image";
    public string imageSuffix = "A_M";
    public int totalLevels = 80;
    public float scrollDuration = 0.2f;

    private int completedLevels = 1;
    private Sprite lockSprite;
    private bool isDestroying = false;

    void Start()
    {
        Debug.Log("LevelMenu2 Start() called");

        if (LevelController.Instance != null && !isDestroying)
            LevelController.Instance.destroyScene();

        lockSprite = Resources.Load<Sprite>("UIImages/LevelLocked");
        completedLevels = GameProgress.LoadLevel();

        CreateLevelButtons();
    }

    void CreateLevelButtons()
    {
        foreach (Transform child in gridParent)
            Destroy(child.gameObject);

        for (int i = 0; i < totalLevels; i++)
        {
            int levelNumber = i + 1;
            GameObject buttonObj = Instantiate(levelButtonPrefab, gridParent);
            Image img = buttonObj.GetComponentInChildren<Image>();
            TMP_Text levelText = buttonObj.GetComponentInChildren<TMP_Text>();
            TMP_Text timerText = buttonObj.transform.GetChild(1).GetComponent<TextMeshProUGUI>();

            if (img != null)
            {
                if (levelNumber <= completedLevels)
                {
                    string imageName = $"{imagePrefix}{levelNumber}{imageSuffix}";
                    ImageCacheManager.Instance.LoadImage(imageName, (loadedSprite) =>
                    {
                        if (loadedSprite != null && img != null)
                        {
                            img.sprite = loadedSprite;
                            img.color = Color.white;
                            levelText.text = levelNumber.ToString();
                            timerText.text = GetFormattedTimerText(levelNumber);
                        }
                    });
                }
                else
                {
                    img.sprite = lockSprite;
                    levelText.text = levelNumber.ToString();
                    img.color = Color.white;
                    timerText.text = "";
                }
            }

            if (levelNumber <= completedLevels)
            {
                Button button = buttonObj.GetComponent<Button>();
                Debug.Log($"Level {levelNumber} button interactable: {button.interactable}");

                // if (button != null)
                //     button.onClick.AddListener(() => OnLevelButtonClicked(levelNumber));
                if (button != null)
                {
                    int currentLevel = levelNumber; // Fix for closure
                    button.onClick.AddListener(() =>
                    {
                        Debug.Log("Button clicked for level " + currentLevel);
                        OnLevelButtonClicked(currentLevel);
                    });
                }

            }
        }

        StartCoroutine(ScrollToCompletedLevel());
    }

    void OnLevelButtonClicked(int levelNumber)
    {
        if (isDestroying) return;

        Debug.Log($"Level {levelNumber} clicked");
        SoundController.Instance.PlayButtonClickSound();
        LevelController.currentLevel = levelNumber - 1;
        StartCoroutine(LoadSceneWithDelay());
    }

    IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(0.5f);
        if (!isDestroying)
            SceneManager.LoadScene(1);
    }

 IEnumerator ScrollToCompletedLevel()
{
    yield return new WaitForEndOfFrame(); // Wait until layout is fully built

    int targetIndex = Mathf.Clamp(completedLevels - 1, 0, totalLevels - 1);
    RectTransform targetRect = gridParent.GetChild(targetIndex).GetComponent<RectTransform>();
    RectTransform contentRect = gridParent.GetComponent<RectTransform>();
    float contentHeight = contentRect.rect.height;
    float viewportHeight = scrollRect.viewport.rect.height;

    // Absolute Y position of the target button within the content
    float targetY = Mathf.Abs(targetRect.anchoredPosition.y);

    // Offset it so the button appears in the center of the viewport
    float centeredY = targetY - (viewportHeight / 2f) + (targetRect.rect.height / 2f);

    // Calculate scroll position (normalized 0 to 1, inverted)
    float scrollPos = Mathf.Clamp01(centeredY / (contentHeight - viewportHeight));
    float startPos = scrollRect.verticalNormalizedPosition;

    float elapsed = 0f;
    while (elapsed < scrollDuration)
    {
        elapsed += Time.deltaTime;
            // float t = Mathf.Clamp01(elapsed / scrollDuration);
        float t = Mathf.SmoothStep(0, 1, elapsed / scrollDuration);
        // float t = Mathf.Pow(elapsed / scrollDuration, 0.5f); // Accelerated ease-out

        scrollRect.verticalNormalizedPosition = Mathf.Lerp(startPos, 1f - scrollPos, t);
        yield return null;
    }

    scrollRect.verticalNormalizedPosition = 1f - scrollPos;
}
    string GetFormattedTimerText(int levelNumber)
    {
        string timerValue = GameProgress.GetTimerValue(levelNumber);
        return timerValue != "00:00" ? timerValue : "";
    }

    void OnDestroy()
    {
        isDestroying = true;
        SceneManager.sceneLoaded -= OnSceneLoaded;
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode) => isDestroying = false;
    void OnSceneUnloaded(Scene scene) => isDestroying = true;
}
