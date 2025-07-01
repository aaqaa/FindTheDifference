using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;

    public int maxLives = 4;
    private int currentLives;

    public Image hearth;
    private Sprite hearthNew;


    public GameObject gameOverScreen; // Assign a UI panel in Inspector

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        currentLives = maxLives;
        if (gameOverScreen != null)
            gameOverScreen.SetActive(false);
    }

    public void resetCurrentLives(){
        this.currentLives = this.maxLives;
    }
    public void RegisterWrongClick()
    {
        currentLives--;
        updateHeart();
        Debug.Log("Wrong Click! Lives left: " + currentLives);
        SoundController.Instance.PlayWrongClickSound();

        if (currentLives <= 0)
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        Debug.Log("Game Over!");    
        if (gameOverScreen != null)
        {                    

            gameOverScreen.SetActive(true);
            LevelTimer.Instance.PauseTimer();
            LevelController.disableImageClick = true;
            LevelController.Instance.timerCanvas.SetActive(false);
            LevelController.Instance.disableDiffCircle(true);
            SoundController.Instance.PlayGameOverSound();

        }
        // Optionally pause game
        // Time.timeScale = 0f;
    }

    // Optional: call to restart
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (hearth == null)
        {
            var hearthObj = GameObject.Find("Heart");
            if (hearthObj != null)
                hearth = hearthObj.GetComponent<Image>();
        }

        // Locate Game Over panel
        if (gameOverScreen == null)
        {
            gameOverScreen = GameObject.Find("GameOver");
        }

        // Update its visual state to match currentLives
        updateHeart();
        if (gameOverScreen != null)
            gameOverScreen.SetActive(false);
    }
    public void updateHeart()
    {

        if (currentLives == 3)
        {
            hearthNew = Resources.Load<Sprite>("UIImages/cracked");
            hearth.sprite = hearthNew;

        }
        else if (currentLives == 2)
        {
            hearthNew = Resources.Load<Sprite>("UIImages/broken");
            hearth.sprite = hearthNew;
        }
        else if (currentLives == 1)
        {
            hearthNew = Resources.Load<Sprite>("UIImages/half");
            hearth.sprite = hearthNew;
        }
    }

    public void resetHealth(){
        hearthNew = Resources.Load<Sprite>("UIImages/heart");
        hearth.sprite = hearthNew;
        currentLives = 4;
    }
}
