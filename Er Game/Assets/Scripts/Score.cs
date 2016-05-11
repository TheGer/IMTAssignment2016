using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Score : MonoBehaviour {

    public static int score = 0;


    void UpdateUI ()
    {
        GetComponent <Text> ().text = "Score: " + score ;
    }


    public void wrongans()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void rightans()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void rightans1()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void rightans2()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void rightans3()
    {
        score += 10;
        Application.LoadLevel(8);
    }
    public void rightans4()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void rightans5()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void rightans6()
    {
        score += 10;
        Application.LoadLevel(12);

    }
    public void rightans7()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void rightans8()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void rightans9()
    {
        score += 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    void Start ()
    {
        UpdateUI();
        if (Application.loadedLevel == 18)
        {
            if (score >= 20)
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
        score++;
        UpdateUI();
    }

    void update()
    {
       

    }



}
