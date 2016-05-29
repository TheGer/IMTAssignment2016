using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

    public void ButtonSpace()
    {
        Application.LoadLevel("Instructions");
    }

    public void Nbutton()
    {
        Application.LoadLevel("SelectionScreen");
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


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
