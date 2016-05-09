using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnvironmentScript : MonoBehaviour {

	public float speed = 10f;
	public float maxSpeed = 15f;
	public float distance = 5000f;

	public Text distanceText;
	public Text speedText;

	private void Update () {

		transform.Rotate (Vector3.up * speed * Time.deltaTime);

		distance = distance - speed * Time.deltaTime;
		CheckLevelPassed ();
		UpdateUI ();
	}

	private void UpdateUI () {
		distanceText.text = string.Format ("Distance: {0}", distance.ToString("#####"));
		speedText.text = string.Format ("Speed: {0}", speed);
	}

	public void IncreaseSpeed(float seconds)
	{
		StartCoroutine (IncreaseSpeedTemporarily (seconds));
	}

	IEnumerator IncreaseSpeedTemporarily(float seconds)
	{
		if (speed >= maxSpeed)
			yield return null;

		speed++;
		UpdateUI ();
		yield return new WaitForSeconds (seconds);
		speed--;
		UpdateUI ();
	}

	private void CheckLevelPassed()
	{
		if (distance > 0)
			return;

		if (State.IsLastLevel)
			SceneManager.LoadScene ("gamepassed");
		else
			SceneManager.LoadScene ("levelpassed");
			
	}
}
