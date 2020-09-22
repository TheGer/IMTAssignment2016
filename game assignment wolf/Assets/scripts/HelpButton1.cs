using UnityEngine;
using System.Collections;

public class HelpButton1 : MonoBehaviour {

	void OnMouseDown()
	{
		Debug.Log ("test button ");
		// loads the game scene
		Application.LoadLevel (6);
	}
	
	void update()
	{ 
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Application.Quit ();
		}
		
	}
}
