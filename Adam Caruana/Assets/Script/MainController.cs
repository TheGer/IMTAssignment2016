using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour {
	
	int lives = 3;
	int score;
	float startTime;
	public float lengthOfGame;
	private bool showPopUp = false;
	private bool showPopUp1 = false;
	private bool showPopUp2 = false;
	public AudioSource audio;
	public AudioSource audio1;

	void Start () {
		startTime = Time.time;
	}
	void Update () {
		
		if ((Time.time - startTime) > lengthOfGame) {
			if (showPopUp == true || showPopUp1 == true){
			showPopUp2 = false;
			}else{
				showPopUp2 = true;
			}
		}
		//float mouseX;
		//mouseX = Input.mousePosition.x;
		
		//Vector3 mainPosition;
		//mainPosition = Camera.main.ScreenToWorldPoint(new Vector3 (mouseX,0, 0));
		//transform.position = new Vector3 (mainPosition.x, transform.position.y, 0);
		
		if (lives == 0) {
			showPopUp = true;
			lives = 3;
		}
		if (score >= 15) {
			showPopUp1 = true;
		}

		//if( Input.GetMouseButton(0))
		//{
		//	transform.position = new Vector3 (mainPosition.x, transform.position.y,5);
		//}
	}

	void OnGUI(){
		
		GUI.color = Color.black;
		GUI.Label (new Rect (10, 25, 100, 50), "Score : "+score);
		GUI.Label (new Rect (10, 40, 100, 50), "lives : "+lives);
		if (showPopUp) {GUI.Window (0, new Rect ((Screen.width / 2) - 150, (Screen.height / 2) - 75, 300, 250), ShowGUIlose, "Game Over");}
		if (showPopUp1){GUI.Window(0, new Rect((Screen.width/2)-150, (Screen.height/2)-75, 300, 250), ShowGUIwin, "Game Over");}
		if (showPopUp2){GUI.Window(0, new Rect((Screen.width/2)-150, (Screen.height/2)-75, 300, 250), Notime, "Game Over");}
	}
	void ShowGUIlose(int windowID)
	{
		GUI.Label(new Rect(65, 40, 200, 30), "You Lose");
		if (GUI.Button(new Rect(50, 150, 75, 30), "OK"))
		{
			showPopUp = false;
			SceneManager.LoadScene("End Game");
		}
	}
	void ShowGUIwin(int windowID)
	{
		GUI.Label(new Rect(65, 40, 200, 30), "You Win");
		if (GUI.Button(new Rect(50, 150, 75, 30), "OK"))
		{
			showPopUp1 = false;
			SceneManager.LoadScene("End Game");
		}
	}
	void Notime(int windowID)
	{
		GUI.Label(new Rect(65, 40, 200, 30), "Ran Out of Time");
		if (GUI.Button(new Rect(50, 150, 75, 30), "OK"))
		{
			showPopUp2 = false;
			SceneManager.LoadScene("End Game");
		}
	}

	void OnTriggerEnter(Collider otherobject)
	{
		if (otherobject.tag == "tincan") {
			score++;
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "tincan2") {
			score++;	score++;
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "Trashcan") {
			lives--;
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "wood1") {
			score++;
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "wood2") {
			score++;	score++;
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "pipe") {
			lives--;
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "box") {
			audio1.Play();
			score++;
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "cone") {
			audio1.Play();
			score++;	score++;
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "trashcan1") {
			lives--;
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "power1") {
			audio.Play();
			transform.localScale = new Vector3 (transform.localScale.x * 2,transform.localScale.y * 1,transform.localScale.z * 1);
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "power2") {
			audio.Play();
			transform.localScale = new Vector3 (transform.localScale.x * 1,transform.localScale.y * 2,transform.localScale.z * 1);
			Destroy (otherobject.gameObject);
		}
		if (otherobject.tag == "power3") {
			audio.Play();
			transform.localScale = new Vector3 (transform.localScale.x * 1,transform.localScale.y * 1,transform.localScale.z * 2);
			Destroy (otherobject.gameObject);
		}
	}
}