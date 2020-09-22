using UnityEngine;
using System.Collections;

public class highScoreButton : MonoBehaviour {


	void OnMouseDown()
	{
		Debug.Log ("test button ");
		// loads the game scene
		Application.LoadLevel (7);
	}
	
	void update()
	{ 
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Application.Quit ();
		}
		
	}

}