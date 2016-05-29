using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using System.Collections;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    private float maxTime = 20f;
 

    // Use this for initialization
    void Start()
    {

        startTime = Time.time;

    }

    // Update is called once per frame
    public void Update()
    {

        // here is where the timer for the game is calculated 

        float timeleft = maxTime - (Time.time - startTime);

        string minutes = ((int)timeleft / 60).ToString();
        float seconds = Mathf.Ceil(timeleft % 60);

        // this code is for printing the text on screen
         
        timerText.text = minutes + ":" + seconds;

        // here is the code so when the timer is 0 it will go to the gameover scene

        if (timeleft <= 0f)  
        {
            SceneManager.LoadScene("GameOver");
        }


    }

    // this code is for the bonus time so when on clicked the player will gain 30 secounds.

    public void TimeButton()
    {
        maxTime =  +30f;
    }






}

