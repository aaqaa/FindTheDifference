using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{

    public void LoadLevelScene(){
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game"); 
        SoundController.Instance.PlayButtonClickSound();
        Application.Quit();
        GameProgress.ResetProgress();
        GameProgress.ResetSoundOn();
    }
    public void LoadMainMenu(){
        SoundController.Instance.PlayButtonClickSound();
        SceneManager.LoadScene(0);
    }

}
