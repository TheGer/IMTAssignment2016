using UnityEngine;
using System.Collections;

public class backToMenu2 : MonoBehaviour {
	void OnMouseDown()
	{
		Debug.Log ("test button ");
		// loads the game scene
		Application.LoadLevel (0);
	}
	
	void update()
	{ 
		
	}
}
