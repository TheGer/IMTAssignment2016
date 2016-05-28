using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using System.Collections;

public class ScoreGenerator : MonoBehaviour {

	private float startTime;
	private float currentTime;
	public float maxTime = 60f;


	public Text scoreText;
	public Text livesText;
	public Text timeText;
	public Text batteryText;



	int score = 0;
	public int targetScore;
	int health = 3;
	float battery = 100f;

	public void Battery (float amount){

		battery += amount;
		if (battery > 100)
			battery = 100;

		UpdateUI ();
	}

	public void AddHealth (int amount) {
		
		health += amount;

		if (health > 3)
			health = 3;
		
		if (health <= 0)
			Application.LoadLevel ("game over");

		UpdateUI ();
		
	}

	public void AddScore (int amount) {

		score += amount;
		UpdateUI ();

	}
	void Start() {

		startTime = Time.time;

	}


	void Update () {

		currentTime = maxTime - (Time.time - startTime);

		UpdateUI ();

		
		float timeleft = maxTime - (Time.time - startTime);

		string minutes = ((int)timeleft / 60).ToString();
		float seconds = Mathf.Ceil(timeleft % 60);
		
		timeText.text = minutes + ":" + seconds;
		
		if (timeleft <= 0f)  
		{
			Application.LoadLevel("game over");
		}

		if ( score >= targetScore)  
		{
			Application.LoadLevel(Application.loadedLevel + 1);
		}

	}




	void UpdateUI () {

		timeText.text = "Time: " + Mathf.Ceil (currentTime);
		scoreText.text = "Score: " + score;
		livesText.text = "Lives: " + health;
		batteryText.text = "Battery: " + battery;
 
	}

}
