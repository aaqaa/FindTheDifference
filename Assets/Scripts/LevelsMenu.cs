    using UnityEngine;
    using UnityEngine.UI;
    using System.Collections.Generic;
    using TMPro;
    using UnityEngine.SceneManagement;
    using System.Collections;

    public class LevlesMenu : MonoBehaviour
    {
        public GameObject levelButtonPrefab;
        public RectTransform content;
        public ScrollRect scrollRect;
        public int totalLevels = 1000;
        public int rowsVisible = 6;
        public int minColumns = 2; // Minimum columns to display

        private GridLayoutGroup grid;
        private List<LevelButton> pooledButtons = new List<LevelButton>();
        private Dictionary<int, Sprite> levelSpritesCache = new Dictionary<int, Sprite>();

        private float buttonHeight;
        private float buttonWidth;
        private int columns;
        private int lastStartIndex = -1;
        private Sprite lockSprite;  
        private Sprite unlockSprite;
        private int completedLevels;
        private bool initialized = false;
        private int visibleButtonCount;
        private float lastScrollUpdateTime;
        private const float scrollUpdateThrottle = 0.1f;
        private bool isDestroying = false;

    
        private class LevelButton
        {
            public GameObject gameObject;
            public Image image;
            public Button button;
            public TMP_Text levelText;
            public TMP_Text timerText;
            public RectTransform rectTransform;
        }

        void Start()
        {
            if (LevelController.Instance != null && !isDestroying)
            {
                LevelController.Instance.destroyScene();   
            }

            // Load resources once
            lockSprite = Resources.Load<Sprite>("UIImages/LevelLocked");
            unlockSprite = Resources.Load<Sprite>("UIImages/ButtonFrame");
        // completedLevels = GameProgress.LoadLevel();
            completedLevels = 35;
            grid = content.GetComponent<GridLayoutGroup>();

            // Configure grid layout
            grid.constraint = GridLayoutGroup.Constraint.Flexible;
            grid.childAlignment = TextAnchor.UpperCenter;
            grid.startCorner = GridLayoutGroup.Corner.UpperLeft;
            grid.startAxis = GridLayoutGroup.Axis.Horizontal;

            // Configure content anchors
            content.anchorMin = new Vector2(0.5f, 1f);
            content.anchorMax = new Vector2(0.5f, 1f);
            content.pivot = new Vector2(0.5f, 1f);

            // Subscribe to events
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.sceneUnloaded += OnSceneUnloaded;
            scrollRect.onValueChanged.AddListener(OnScrollValueChanged);

            StartCoroutine(InitializeAfterFrame());
            AdsManager.Instance.LoadBanner();
        }

        void OnScrollValueChanged(Vector2 position)
        {
            if (Time.time - lastScrollUpdateTime > scrollUpdateThrottle && !isDestroying)
            {
                lastScrollUpdateTime = Time.time;
                UpdateVisibleButtons();
            }
        }

       IEnumerator InitializeAfterFrame()
{
    yield return null; // Wait one frame for layout calculations

    if (isDestroying) yield break;

    // Calculate layout
    buttonWidth = grid.cellSize.x + grid.spacing.x;
    buttonHeight = grid.cellSize.y + grid.spacing.y;
    columns = GetFlexibleColumnCount();

    int totalRows = Mathf.CeilToInt(totalLevels / (float)columns);
    float contentWidth = columns * buttonWidth - grid.spacing.x;
    content.sizeDelta = new Vector2(contentWidth, totalRows * buttonHeight);

    // Create pooled buttons
    visibleButtonCount = columns * (rowsVisible + 2);
    for (int i = 0; i < visibleButtonCount; i++)
    {
        if (isDestroying) yield break;

        var btnObj = Instantiate(levelButtonPrefab, content);
        var btn = new LevelButton
        {
            gameObject = btnObj,
            image = btnObj.GetComponent<Image>(),
            button = btnObj.GetComponent<Button>(),
            levelText = btnObj.GetComponentInChildren<TMP_Text>(),
            rectTransform = btnObj.GetComponent<RectTransform>()
        };

        if (btnObj.transform.childCount > 1)
        {
            btn.timerText = btnObj.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        }

        pooledButtons.Add(btn);
        btnObj.SetActive(false);
    }

    // initialized = true;
    // UpdateVisibleButtons();

    // Wait another frame so content.rect.height becomes accurate
    yield return null;

initialized = true;
UpdateVisibleButtons();

// Ensure layout is fully calculated
LayoutRebuilder.ForceRebuildLayoutImmediate(content);

// Wait for frame end to ensure all UI is finalized 
yield return new WaitForEndOfFrame();

// Scroll to completed level
ScrollToLevelButton(completedLevels);

}


void ScrollToLevelButton(int levelToScrollTo)
{
    if (levelToScrollTo <= 0 || levelToScrollTo > totalLevels || columns <= 0) return;

    int row = (levelToScrollTo - 1) / columns;

    float targetY = (row * buttonHeight) - (scrollRect.viewport.rect.height / 2f) + (buttonHeight / 2f);

    float contentHeight = content.rect.height;
    float viewportHeight = scrollRect.viewport.rect.height;

    float scrollableHeight = Mathf.Max(1f, contentHeight - viewportHeight);

    targetY = Mathf.Clamp(targetY, 0f, scrollableHeight);

    float normalizedY = 1f - (targetY / scrollableHeight);
    normalizedY = Mathf.Clamp01(normalizedY);

    scrollRect.verticalNormalizedPosition = normalizedY;

    Debug.Log($"[Scroll Centered] Level: {levelToScrollTo}, Row: {row}, TargetY: {targetY}, NormalizedY: {normalizedY}");
}

        int GetFlexibleColumnCount()
        {
            if (grid == null || isDestroying) return minColumns;

            // Calculate using viewport width
            float availableWidth = scrollRect.viewport.rect.width 
                                - grid.padding.left 
                                - grid.padding.right;

            float cellWidthWithSpacing = grid.cellSize.x + grid.spacing.x;
            int calculatedColumns = Mathf.FloorToInt(availableWidth / cellWidthWithSpacing);

            return Mathf.Max(calculatedColumns, minColumns);
        }

        void UpdateVisibleButtons()
        {
            if (!initialized || columns == 0 || isDestroying) return;

            float scrollY = Mathf.Max(0, content.anchoredPosition.y);
            int startRow = Mathf.FloorToInt(scrollY / buttonHeight);
            int startIndex = startRow * columns;

            if (startIndex == lastStartIndex) return;
            lastStartIndex = startIndex;

            for (int i = 0; i < pooledButtons.Count; i++)
            {
                if (isDestroying) return;

                int levelIndex = startIndex + i;
                var btn = pooledButtons[i];

                if (btn == null || btn.gameObject == null) continue;

                int levelNumber = levelIndex + 1;
                bool isUnlocked = levelIndex < completedLevels;

                // Position calculation
                int row = (i / columns) + startRow;
                int col = i % columns;
                btn.rectTransform.anchoredPosition = new Vector2(175+col * buttonWidth, -row * buttonHeight);

                // Update visuals
                UpdateButtonVisuals(btn, levelNumber, isUnlocked);
                
                // Set click handler
                SetupButtonClickHandler(btn, levelNumber, isUnlocked);

                btn.gameObject.SetActive(true);
            }
        }

        void UpdateButtonVisuals(LevelButton btn, int levelNumber, bool isUnlocked)
        {
            btn.image.color = Color.black;
            if (isUnlocked)
            {
                if (btn.image != null)
                {
                    if (!levelSpritesCache.TryGetValue(levelNumber, out var sprite))
                    {
                        string menuImageKey = $"Image{levelNumber}A_M";
                        btn.image.sprite = null;
                        ImageCacheManager.Instance.LoadImage(menuImageKey, btn.image);
                        levelSpritesCache[levelNumber] = btn.image.sprite;
                    }
                    else
                    {
                        btn.image.sprite = sprite;
                    }
                    btn.image.color = Color.white;
                }

                if (btn.levelText != null) btn.levelText.text = levelNumber.ToString();
                if (btn.timerText != null) btn.timerText.text = GetFormattedTimerText(levelNumber);
            }
            else
            {
                if (btn.image != null)
                {
                    btn.image.sprite = lockSprite;
                    btn.image.color = Color.black;
                }
                if (btn.levelText != null) btn.levelText.text = levelNumber.ToString();
                if (btn.timerText != null) btn.timerText.text = "";
            }
        }

        string GetFormattedTimerText(int levelNumber)
        {
            string timerValue = GameProgress.GetTimerValue(levelNumber);
            return timerValue != "00:00" ? timerValue : "";
        }

        void SetupButtonClickHandler(LevelButton btn, int levelNumber, bool isUnlocked)
        {
            if (btn.button != null)
            {
                btn.button.onClick.RemoveAllListeners();
                if (isUnlocked)
                {
                    btn.button.onClick.AddListener(() => OnLevelClick(levelNumber));
                }
            }
        }

        void OnLevelClick(int level)
        {   
            if (isDestroying) return;

            SoundController.Instance.PlayButtonClickSound();
            LevelController.currentLevel = level - 1;
            StartCoroutine(LoadSceneWithDelay());
        }

        IEnumerator LoadSceneWithDelay()
        {
            yield return new WaitForSeconds(0.5f);
            if (!isDestroying) SceneManager.LoadScene(1);
        }

        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            isDestroying = false;
        }

        void OnSceneUnloaded(Scene scene)
        {
            isDestroying = true;
        }

        void OnDestroy()
        {
            isDestroying = true;
            scrollRect.onValueChanged.RemoveListener(OnScrollValueChanged);
            SceneManager.sceneLoaded -= OnSceneLoaded;
            SceneManager.sceneUnloaded -= OnSceneUnloaded;

            foreach (var btn in pooledButtons)
            {
                if (btn != null && btn.button != null)
                {
                    btn.button.onClick.RemoveAllListeners();
                }
            }
        }
    }   