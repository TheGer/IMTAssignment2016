using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour {

	public EnvironmentScript environment;

	public AudioClip fallingClip;
	public AudioClip movingClip;
	public AudioClip healthClip;
	public AudioClip scoreClip;
	public AudioClip boostClip;
	private AudioSource audioSource;

	public int maxLives;
	public int lives = 5;
	public int currentScore = 0;
	public bool isLastLevel = false;

	public Text livesText;
	public Text squidText;
    
    public float horizontal = 0f;
	public float vertical = 0f;

	void Awake () {
		audioSource = GetComponent <AudioSource> ();
	}

	void Start () {
		State.IsLastLevel = isLastLevel;
		State.CurrentLevel = SceneManager.GetActiveScene ().buildIndex;
		State.Scores.Add (currentScore);
		UpdateUI ();	
	}

	void Update (){
		transform.Translate (Vector3.right * 20f * Input.GetAxis ("Horizontal")*Time.deltaTime);
		transform.Translate (Vector3.up * 20f * Input.GetAxis ("Vertical")*Time.deltaTime);

        transform.Translate (Vector3.right * 20f * horizontal *Time.deltaTime);
		transform.Translate (Vector3.up * 20f * vertical *Time.deltaTime);

		if (transform.position.y <= -7.6f) {
			Vector3 pos = transform.position;
			pos.y = -7.6f;
			transform.position = pos;
		}
		if (transform.position.y > 1f) {
			Vector3 pos = transform.position;
			pos.y = 1f;
			transform.position = pos;
		}
		if (transform.position.x <= -12.1f) {
			Vector3 pos = transform.position;
			pos.x = -12.1f;
			transform.position = pos;
		}
		if (transform.position.x > 12f) {
			Vector3 pos = transform.position;
			pos.x = 12f;
			transform.position = pos;
		}

	
	}


	void OnTriggerEnter2D (Collider2D col) {

		var component = col.GetComponent <MovingObject> ();
		if (component != null)
			component.Animate ();
		else {
			col.GetComponent<FallingObject> ().Animate ();
		}

		switch (col.GetComponent <ObjectScript> ().type) {

			case ObjectType.Health:				
				if (lives < maxLives) lives++;
				audioSource.clip = healthClip;
				audioSource.Play ();
				break;

			case ObjectType.Score:				
				currentScore += 20;
				audioSource.clip = scoreClip;
				audioSource.Play ();
				break;

			case ObjectType.DamagingMovingMaterial:
				lives--;
				audioSource.clip = movingClip;
				audioSource.Play ();
				break;

			case ObjectType.DamagingFallingMaterial:
				lives--;
				audioSource.clip = fallingClip;
				audioSource.Play ();
				break;

			case ObjectType.Boostpack:
				environment.IncreaseSpeed (5);
				audioSource.clip = boostClip;
				audioSource.Play ();
				break;
		}

		State.CurrentScore = currentScore;
		UpdateUI ();
		CheckGameOver ();
	}

	void UpdateUI () {

		livesText.text = string.Format ("Life: {0}", lives);
		squidText.text = string.Format ("Score:{0}", currentScore);
	}

	private void CheckGameOver()
	{
		if (lives > 0)
			return;
		
		SceneManager.LoadScene ("gameover");
	}
}
