using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

    public void ButtonSpace()
    {
        Application.LoadLevel("Instructions");
    }

    public void Nbutton()
    {
        Application.LoadLevel(2);
    }

    public void Bodybutton()
    {
        Application.LoadLevel(4);
    }
    public void headbutton()
    {
        Application.LoadLevel(9);
    }
    public void Bonebutton()
    {
        Application.LoadLevel(13);
    }

    public void Gamebutton()
    {
        Application.LoadLevel(3);
    }

    public void Exitbutton()
    {
        Application.Quit();
    }

    public void startGamebutton()
    {
        Application.LoadLevel(17);
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
