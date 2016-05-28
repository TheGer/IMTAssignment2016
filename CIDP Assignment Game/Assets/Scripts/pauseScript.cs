using UnityEngine;
using System.Collections;

public class pauseScript : MonoBehaviour {

		public bool paused;




	// Use this for initialization
	void Start () {
	
		paused = false;


	}
	
	// Update is called once per frame
	public void Update () {

	
		if (Input.GetKeyDown (KeyCode.Space)) {
			paused = !paused;

		}
		if (paused) {
			Time.timeScale = 0;
		} 
		else if (!paused) {
			Time.timeScale = 1;
		}

	}
	//this function enables the use of a pause button in the game. 
	//It is coded so whenever the button is pressed the game is paused and when it released the game will continue
	public void pausebutton () {
		
		

		paused = !paused;
			
		if (paused) {
			Time.timeScale = 0;
		} 
		else if (!paused) {
			Time.timeScale = 1;
		}
		
	}


}

