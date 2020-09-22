using UnityEngine;
using System.Collections;

public class wolf : MonoBehaviour {

	
	public int score;
	//so I can set number of lives from Unity
	public int lives;
	public GUISkin skin;	
	public float lengthOfGame;	
	float startTime;

	
	
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	void OnGUI()
	{
		GUI.skin = skin;
		GUI.Label (new Rect(0,0,150,30),"Score :"+score);
		GUI.Label (new Rect(0,30,150,30),"Lives :"+lives);

		if (lives < 1) {
			// take me back to the menue
			Application.LoadLevel(5); 
		}
		
		
	}



	void OnTriggerEnter(Collider other)
	{
		if (gameObject .tag == "obsticle") {
			//score goes up by one when starfish
			//hits lobster
			score--;
			lives--; 
            //lives-=2;/ entering the amoutn to take exactly 

			//destroy the food so it disappears when
			//it hits lobster


			Destroy (gameObject);


		}
		if (gameObject.tag == "healthyFood") {
			//score goes up by one when healthy food falls
			//hits plate
			score++;
			//destroy the sfood so it disappears when
			//it hits plate
			

			Destroy (gameObject);
		}


	}


	
	// Update is called once per frame
	void Update () {

			
						
			//if the game has been running longer than length of game
				
		float mouseX;
		
		//mouse position
		mouseX = Input.mousePosition.x;
		


		Vector3 platePosition;
		
		platePosition = Camera.main.ScreenToWorldPoint(
			new Vector3(mouseX,0,10f));

        Debug.Log(platePosition);

        //to keep the y position of the plate, we only use the X
        transform.position = 
			new Vector3(platePosition.x,transform.position.y,0);
		
		
	}
}
