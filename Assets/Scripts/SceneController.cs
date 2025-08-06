using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public GameObject noInternetScreen;
    public void LoadLevelScene(){

        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game"); 
        SoundController.Instance.PlayButtonClickSound();
        Application.Quit();
        GameProgress.ResetSoundOn();
    }
    public void LoadMainMenu(){
    if(noInternetScreen != null)
        noInternetScreen.SetActive(false);
        SoundController.Instance.PlayButtonClickSound();
        SceneManager.LoadScene(0);
    }

}
