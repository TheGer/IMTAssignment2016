using UnityEngine;
using System.Collections;

public class textController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) ) {
			//the name of the trigger to happen when R is pressed in the animator inside the stick figure
			GetComponent <Animator> ().SetTrigger ("clicked");
		}
	}

	public void forestButtonPressed()
	{
		Application.LoadLevel (1);
	}

	public void urbanButtonPressed()
	{

		Application.LoadLevel (2);
	}

	public void wastelandButtonPressed()
	{

		Application.LoadLevel (3);
	}

	public void exitButtonPressed()
	{
		Application.Quit();
	}

	public void playAgainPressed()
	{
		Application.LoadLevel (0);
	}

	public void menuPressed()
	{
		Application.LoadLevel (0);
	}
}

		
