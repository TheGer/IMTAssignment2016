using UnityEngine;
using System.Collections;

public class backButton : MonoBehaviour {
	
	void OnMouseDown()
	{
		Debug.Log ("test button ");
		// loads the game scene
		Application.LoadLevel (0);
	}
	
	void update()
	{ 
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Application.Quit ();
		}
		
	}
}
