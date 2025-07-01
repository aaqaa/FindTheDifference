using System.Collections;
using UnityEngine;

public class StarController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // public static int totalNumberOfDiff=0;
    // public static int numberOfDiffSpotted; 
    public static bool showNextStar = false;
    public static int currentStar;
    private GameObject[] stars;
    void Start()
    {
        mainRoutine();
        // stars = new GameObject[gameObject.transform.childCount];
        // for(int i=0;i<stars.Length;i++){
        //     stars[i]= gameObject.transform.GetChild(i).gameObject;
        //  }
        //  Debug.Log(stars.Length);
        //  StartCoroutine(initStars());
    }
    IEnumerator initStars(){
        yield return new WaitForSeconds(1);
        for(int i=0;i<LevelController.totalNumberOfDiff;i++){
            stars[i]= gameObject.transform.GetChild(i).gameObject;
            stars[i].SetActive(true);
         }

    }
    // Update is called once per frame
    void Update()
    {   
        if(showNextStar){
            string s = "starsActive"+currentStar;
            stars[currentStar].GetComponent<Animator>().Play(s);
            stars[currentStar].transform.GetChild(0).gameObject.SetActive(true);
            currentStar +=1;
            showNextStar = false;
            
        }
        
    }

    public void mainRoutine(){  
         stars = new GameObject[gameObject.transform.childCount];
        for (int i = 0; i < stars.Length; i++)
        {

            stars[i] = gameObject.transform.GetChild(i).gameObject;
            stars[i].GetComponent<Animator>().Rebind();
            stars[i].GetComponent<Animator>().Update(0f);
            stars[i].transform.GetChild(0).gameObject.SetActive(false);
            stars[i].SetActive(false);

         }
         Debug.Log(stars.Length);
         StartCoroutine(initStars());
    }
}
