using UnityEngine;
using System.Collections;

public class startbotton : MonoBehaviour {

	void OnMouseDown()
	{
		Debug.Log ("test button ");
		// loads the game scene
		Application.LoadLevel (1);
	}
	
	void update()
	{ 
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Application.Quit ();
		}
		// onselect the user may start the game when the button is selected
		
	}
}
