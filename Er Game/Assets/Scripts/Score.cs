using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Score : MonoBehaviour {

    public static int score = 0;

    // this will update each sence with the score 
    void UpdateUI ()
    {
        GetComponent <Text> ().text = "Score: " + score ;
    }

    // this will not add any points to the score
    public void wrongans()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // this will not add 10 points to the score
    public void rightans()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // this will not add 10 points to the score
    public void rightans1()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // this will not add 10 points to the score
    public void rightans2()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // this will not add 10 points to the score
    public void rightans3()
    {
        score += 10;
        SceneManager.LoadScene(8);
    }
    // this will not add 10 points to the score
    public void rightans4()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // this will not add 10 points to the score
    public void rightans5()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // this will not add 10 points to the score
    public void rightans6()
    {
        score += 10;
        SceneManager.LoadScene(12);

    }
    // this will not add 10 points to the score
    public void rightans7()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // this will not add 10 points to the score
    public void rightans8()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // this will not add 10 points to the score
    public void rightans9()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    void Start ()
    {
        UpdateUI();
        // when scene 18 is loaded it will show the game over scene where if the user gets over or equal to 100 it will save you have won!
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            if (score >= 100)
            {
                GetComponent<Text>().text = " Final Score: " + score + "             You have won!";

            }
            else
            {
                GetComponent<Text>().text = " Final Score: " + score + "            You have Lost!";
            }
        }
    }

    public void addscore ()
    {
        // this will not add 1 points to the score for each organ that collides with the cooler
        score++;
        UpdateUI();
    }

    void update()
    {
       

    }



}
