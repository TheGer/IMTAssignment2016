using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonController : MonoBehaviour {

    // this code basically loads the scenes when on clicked

    public void mainmenu()
    {
        SceneManager.LoadScene(2);
    }

    public void ButtonSpace()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Nbutton()
    {
        SceneManager.LoadScene(2);
    }

    public void Bodybutton()
    {
        SceneManager.LoadScene(4);
    }
    public void headbutton()
    {
        SceneManager.LoadScene(9);
    }
    public void Bonebutton()
    {
        SceneManager.LoadScene(13);
    }

    public void Gamebutton()
    {
        SceneManager.LoadScene(3);
    }

    public void Exitbutton()
    {
        Application.Quit();
    }

    public void startGamebutton()
    {
        SceneManager.LoadScene(17);
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
