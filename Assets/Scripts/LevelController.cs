using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

    public static int currentLevel;
    public static int totalNumberOfDiff = 0;
    public static int numberOfDiffSpotted;
    public GameObject winCanvas;
    public GameObject comingSoonCanvas;
    public GameObject gameOverCanvas;
    private LevelData currentLevelData;

    public GameObject[] diffCircles;

    public SpriteRenderer image1;
    public SpriteRenderer image2;

    public GameObject stars;
    private bool isWin = false;
    private SpriteRenderer sr;
    private Color color;
    public static LevelController Instance;
    public GameObject parentDiffCircle;
    public GameObject timerCanvas;
    public TMP_Text winCanvasTimertext;
    public static bool disableImageClick;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        //load current level.
        loadNextLevel();
        LevelTimer.Instance.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); // Closes the app
        }
        if (numberOfDiffSpotted == totalNumberOfDiff && !isWin)
        {
            //show win screen
            isWin = true;
            disableImageClick = true;
            if (GameProgress.LoadLevel() < currentLevel)
            {   
                GameProgress.SaveLevel(currentLevel + 1);    
            }
            SoundController.Instance.PlayLevelCompletedSound();
            LevelTimer.Instance.StopTimer();
            StartCoroutine(showWinCanvas());    
            LevelTimer.Instance.StopTimer();
        }
    }

    public void setCurrentLevelParams()
    {
        totalNumberOfDiff = currentLevelData.numberOfDiff;
        numberOfDiffSpotted = 0;
        setDiffCoordinates();
    }
    private void setDiffCoordinates()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i < totalNumberOfDiff)
            {

                diffCircles[i].SetActive(true);
                diffCircles[i].GetComponent<DifferenceSpot>().resetIsFound();
                diffCircles[i].transform.position = currentLevelData.diffPos1[i];
                diffCircles[i].transform.localScale = currentLevelData.diffScale[i];
                // diffCircles[i].GetComponent<SpriteRenderer>().enabled = false;
                setAlpha(diffCircles[i], 0f);

                diffCircles[i].GetComponent<BoxCollider2D>().enabled = true;
            }
            else
            {
                diffCircles[i].SetActive(false);
            }

        }
        for (int i = 0; i < 5; i++)
        {
            if (i < totalNumberOfDiff)
            {
                diffCircles[i + 5].SetActive(true);
                diffCircles[i + 5].GetComponent<DifferenceSpot>().resetIsFound();
                diffCircles[i + 5].transform.position = currentLevelData.diffPos2[i];
                diffCircles[i + 5].transform.localScale = currentLevelData.diffScale[i];
                // diffCircles[i+5].GetComponent<SpriteRenderer>().enabled = false;
                setAlpha(diffCircles[i + 5], 0f);
                diffCircles[i + 5].GetComponent<BoxCollider2D>().enabled = true;
            }
            else
            {
                diffCircles[i + 5].SetActive(false);
            }
        }
    }
    private void initLevelsData()
    {
        // currentLevelData = new LevelData();
        //Set first level data

        currentLevelData = LevelData.getCurrentLevelData(currentLevel);
        Debug.Log("d");
    }

   

    IEnumerator showWinCanvas()
    {
        // int randomInt = Random.Range(1, 7);
        // if (randomInt == 1 || randomInt == 2 || randomInt == 5)
        
        yield return new WaitForSeconds(1);
        winCanvas.SetActive(true);
        winCanvasTimertext.text = LevelTimer.GetWinTimer();
        timerCanvas.SetActive(false);
        disableDiffCircle(true);
        if(currentLevel%7==0)
        { 
            AdsManager.Instance.ShowInterstitial();    
        }
        isWin = true;
    }
    public void loadImages()
    {
        Sprite image1New = Resources.Load<Sprite>("Images/Image" + currentLevel + "A");
        image1.sprite = image1New;

        Sprite image2New = Resources.Load<Sprite>("Images/Image" + currentLevel + "B");
        image2.sprite = image2New;
    }
    public void resetStars()
    {
        StarController sc = stars.GetComponent<StarController>();
        sc.mainRoutine();

    }

    public void LoadImagesAddressable(int level)
    {
        string imageAKey = $"Image{level}A";
        string imageBKey = $"Image{level}B";

        Debug.Log(imageAKey);
        Debug.Log(imageBKey);

        // ImageCacheManager.Instance.LoadImage(imageAKey, image1);
        // ImageCacheManager.Instance.LoadImage(imageBKey, image2);

        ImageCacheManager.Instance.LoadImage(imageAKey, (loadedSprite) =>
                        {
                            if (loadedSprite != null)
                            {
                                image1.sprite = loadedSprite;
                            }
                        });
         ImageCacheManager.Instance.LoadImage(imageBKey, (loadedSprite) =>
                        {
                            if (loadedSprite != null)
                            {
                                image2.sprite = loadedSprite;
                                LevelTimer.Instance.StartTimer();
                            }
                        });

    }

    public void loadNextLevel()
    {
        Destroy(GameObject.FindGameObjectWithTag("HintCircle"));

        // AdsManager.Instance.LoadRewarded();
        HealthManager.Instance.resetCurrentLives();
        // LevelTimer.Instance.StartTimer();
        timerCanvas.SetActive(true);
        AdsManager.Instance.LoadInterstitial();
        disableImageClick = false;
        disableDiffCircle(false);
        winCanvas.SetActive(false);
        currentLevel += 1;
        StarController.currentStar = 0;
        isWin = false;
        numberOfDiffSpotted = 0;
        // loadImages();
        initLevelsData();
        if (currentLevelData != null)
        {
            setCurrentLevelParams();
            LoadImagesAddressable(currentLevel);
            HealthManager.Instance.resetHealth();
            resetStars();
        }
        else
        {
            comingSoonCanvas.SetActive(true);
        }
       
        // initLevelsData();
        


    }

    public void retryLevel()
    {
        disableImageClick = false;
        disableDiffCircle(false);
        gameOverCanvas.SetActive(false);
        timerCanvas.SetActive(true);
        LevelTimer.Instance.ResumeTimer();
        isWin = false;
        HealthManager.Instance.resetHealth();
        AdsManager.Instance.ShowRewardedVideo(() =>
        {
            Debug.Log("Player rewarded!");
            // Give coins, revive player, etc.
            disableImageClick = false;
            disableDiffCircle(false);
            gameOverCanvas.SetActive(false);
            timerCanvas.SetActive(true);
            isWin = false;
            HealthManager.Instance.resetHealth();
        });

        // AdsManager.Instance.LoadRewarded();
    }
    public void setAlpha(GameObject obj, float value)
    {
        sr = obj.GetComponent<SpriteRenderer>();
        color = sr.color;
        color.a = value;
        sr.color = color;
    }

    public void disableDiffCircle(bool disable)
    {
        parentDiffCircle.SetActive(!disable);
    }
    public void destroyScene()
    {
        Destroy(gameObject);
    }
    public void LoadMainMenu(){
        SoundController.Instance.PlayButtonClickSound();
        SceneManager.LoadScene(0);
    }
}
