using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
using System.Threading;

public class LevlesMenu : MonoBehaviour
{
    public GameObject levelButtonPrefab;
    public RectTransform content;
    public ScrollRect scrollRect;
    public int totalLevels = 1000;
    public int rowsVisible = 6;

    private GridLayoutGroup grid;
    private List<GameObject> pooledButtons = new List<GameObject>();

    private float buttonHeight;
    private float buttonWidth;
    private int columns;
    private int lastStartIndex = -1;
    private Sprite lockSprite;  
    private Sprite unlocckSprite;
    private int completedLevels;
    private string menuImageKey;
    private string levelTimerText;
    void Start()
    {
        if( LevelController.Instance != null){
         LevelController.Instance.destroyScene();   
        }
        lockSprite = Resources.Load<Sprite>("UIImages/LevelLocked");
        unlocckSprite = Resources.Load<Sprite>("UIImages/ButtonFrame");
        completedLevels = GameProgress.LoadLevel();
        grid = content.GetComponent<GridLayoutGroup>();
        scrollRect.onValueChanged.AddListener(_ => UpdateVisibleButtons());

        // Use Coroutine to wait until layout is ready (ensures correct width)
        StartCoroutine(InitializeAfterFrame());
        AdsManager.Instance.LoadBanner();
    }

    System.Collections.IEnumerator InitializeAfterFrame()
    {
        yield return null; // wait one frame

        buttonWidth = grid.cellSize.x + grid.spacing.x;
        buttonHeight = grid.cellSize.y + grid.spacing.y;

        // Dynamically calculate how many columns fit in current width
        float contentWidth = content.rect.width;
        // columns = Mathf.FloorToInt(contentWidth / buttonWidth);
        // columns =3;
        columns = GetFlexibleColumnCount();

        int visibleButtons = columns * (rowsVisible + 2);
        int totalRows = Mathf.CeilToInt(totalLevels / (float)columns);
        float totalHeight = totalRows * buttonHeight;
        content.sizeDelta = new Vector2(content.sizeDelta.x, totalHeight);

        for (int i = 0; i < visibleButtons; i++)
        {
            GameObject btn = Instantiate(levelButtonPrefab, content);
            pooledButtons.Add(btn);
        }

        UpdateVisibleButtons();
    }

    void UpdateVisibleButtons()
    {
        if (columns == 0) return; // not yet initialized

        float scrollY = Mathf.Max(0, content.anchoredPosition.y);
        int startRow = Mathf.FloorToInt(scrollY / buttonHeight);
        int startIndex = startRow * columns;

        if (startIndex == lastStartIndex) return;
        lastStartIndex = startIndex;

        for (int i = 0; i < pooledButtons.Count; i++)
        {
            int levelIndex = startIndex + i;
            GameObject btn = pooledButtons[i];

            if (levelIndex >= totalLevels)
            {
                btn.SetActive(false);
                continue;
            }

            btn.SetActive(true);
            if(levelIndex < completedLevels){
                menuImageKey = $"Image{(levelIndex+1)}A";
                ImageCacheManager.Instance.LoadImage(menuImageKey, btn.GetComponent<Image>());
                // Sprite levelSprite =  ImageCacheManager.Instance.LoadImage(imageAKey, levelSprite);
                // Debug.Log("Images/Image"+(levelIndex + 1) + "A");
                // btn.GetComponent<Image>().sprite = levelSprite;
                btn.GetComponent<Image>().color = Color.white;
                btn.GetComponentInChildren<TMP_Text>().text = "" + (levelIndex + 1);
                levelTimerText = GameProgress.GetTimerValue(levelIndex + 1);
                if(levelTimerText!="00:00"){
                    Transform child = btn.transform.GetChild(1);
                    // child.GetComponent<TMP_Text>().text = levelTimerText;
                    TextMeshProUGUI tmp = child.GetComponent<TextMeshProUGUI>();
                    if (tmp != null)
                    {
                        tmp.text = levelTimerText;
                    }
                }
                Debug.Log("Timer Text : " + levelTimerText);
              

                }
            else{
                btn.GetComponent<Image>().sprite = lockSprite;
                btn.GetComponentInChildren<TMP_Text>().text = "";
               }
            

            int row = (i / columns) + startRow;
            int col = i % columns;
            btn.GetComponent<RectTransform>().anchoredPosition = new Vector2(175+col * buttonWidth, -row * buttonHeight);
            
            int capturedIndex = levelIndex + 1;
            btn.GetComponent<Button>().onClick.RemoveAllListeners();
            btn.GetComponent<Button>().onClick.AddListener(() => OnLevelClick(capturedIndex));
        }
    }
 int GetFlexibleColumnCount()
    {
        RectTransform rectTransform = grid.GetComponent<RectTransform>();

        float totalWidth = rectTransform.rect.width;

        float cellWidth = grid.cellSize.x;
        float spacingX = grid.spacing.x;
        float paddingLeft = grid.padding.left;
        float paddingRight = grid.padding.right;

        float availableWidth = totalWidth - paddingLeft - paddingRight + spacingX;
        int columns = Mathf.FloorToInt((availableWidth) / (cellWidth + spacingX));

        return Mathf.Max(columns, 1); // Always return at least 1
    }
    void OnLevelClick(int level)
    {   
        SoundController.Instance.PlayButtonClickSound();
        Debug.Log("Clicked Level " + level);
        LevelController.currentLevel =level-1;

        // SceneManager.LoadScene(1);
        StartCoroutine(LoadSceneWithDelay());
    }

    IEnumerator LoadSceneWithDelay()
    {
    yield return new WaitForSeconds(0.5f);
    SceneManager.LoadScene(1);
    }
}