using Unity.VisualScripting;
using UnityEngine;

public class DifferenceSpot : MonoBehaviour
{
    
    public bool found = false;
    public GameObject twinCircle;
    SpriteRenderer sr;
    Color color;

    void OnMouseDown()
    {
        Debug.Log("Clicked");   
        if (found) return;
        SoundController.Instance.PlayDiffClickSound();
        found = true;
        LevelController.numberOfDiffSpotted += 1; 
        Debug.Log("NumberOfDiffSpotted : " +LevelController.numberOfDiffSpotted);
        setAlpha(gameObject,255f);
        setAlpha(twinCircle,255f);
        twinCircle.GetComponent<DifferenceSpot>().setFound(true);
        // twinCircle.GetComponent<SpriteRenderer>().enabled = true;
        // GetComponent<Collider2D>().enabled = false;
        // twinCircle.GetComponent<Collider2D>().enabled = false;
        StarController.showNextStar = true;
    }

    public void resetIsFound(){
        this.found = false;
    }
    public void setAlpha(GameObject obj, float value){
        sr = obj.GetComponent<SpriteRenderer>();
        color = sr.color;
        color.a = value;
        sr.color = color;
    }

    public void setFound(bool value){
        this.found = value;
    }
}
