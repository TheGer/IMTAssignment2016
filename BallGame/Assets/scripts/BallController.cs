using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
[RequireComponent(typeof(AudioSource))]

public class BallController : MonoBehaviour {

	public float speed;
	public Vector3 jump;
	private Rigidbody rb;
	private Vector3 rbPosition;
	public Material bluePill;
	public Material blackPill;
	public Material redPill;
	public Material greenBox;
	public Material brownPill;
	public Material Gpillm;
	public Material Cpill;
	public Material sonicPill;
	public Material hulkPill;
	public Material GhostPill;
	public float gravityEquation;
	public float moveForce = 5, boostMultiplier = 2;

	public AudioClip collectingCoin;
	public AudioClip PowerUpSound;
	public AudioClip jumpSound;
	public AudioClip redSound;
	public AudioClip redButtonSound;

	//private AudioSource source = GetComponent<AudioSource>();

	public static float Score = 0;
	public Text scoreText;
	public Text winText;
	public Text nextLevelIn;
	public Text nextLevelCountdownText;
	public float nextLevelCountdown = 0;
	int currentLevel;

	private AudioSource source;

	public bool active = true;

	private int moveVertical = 0;
	private int moveHorizontal = 0;

	void Awake () {

		source = GetComponent <AudioSource> ();
		rb = GetComponent<Rigidbody> ();

	}

	void Start (){


		int currentLevel = Application.loadedLevel;
		Debug.Log (currentLevel);


		Score = 0;
		SetScoreText ();
		winText.text = "";
		nextLevelIn.text = "";

		nextLevelCountdown = 3;
		nextLevelCountdownText.text = "";
		//testing gravity so wrong
		//Physics.gravity = new Vector3 (0, ((Time.deltaTime * -10) * (-10* Time.deltaTime)), 0);

	}


	IEnumerator CDBRO(){
		nextLevelCountdownText.text = nextLevelCountdown.ToString ();
		yield return new WaitForSeconds(1);
		nextLevelCountdown = nextLevelCountdown - 1;
		nextLevelCountdownText.text = nextLevelCountdown.ToString ();
		yield return new WaitForSeconds(1);
		nextLevelCountdown = nextLevelCountdown - 1;
		nextLevelCountdownText.text = nextLevelCountdown.ToString ();
		yield return new WaitForSeconds(1);
		nextLevelCountdown = nextLevelCountdown - 1;
		Application.LoadLevel(Application.loadedLevel+1);
	}
	IEnumerator CDBRObugone(){
		nextLevelCountdownText.text = nextLevelCountdown.ToString ();
		yield return new WaitForSeconds(1);
		nextLevelCountdown = nextLevelCountdown - 1;
		nextLevelCountdownText.text = nextLevelCountdown.ToString ();
		yield return new WaitForSeconds(1);
		nextLevelCountdown = nextLevelCountdown - 1;
		nextLevelCountdownText.text = nextLevelCountdown.ToString ();
		yield return new WaitForSeconds(1);
		nextLevelCountdown = nextLevelCountdown - 1;
		Application.LoadLevel(currentLevel+2);
	}


	void SetScoreText(){
		scoreText.text = "Score: " + Score.ToString ();
		if (Score == 7) {
			winText.text = "YOU WIN";
			nextLevelIn.text ="Next Level IN";
			StartCoroutine(CDBRO());
	
		}

	}

	void scoreWinCoin(){
		scoreText.text = "Score: " + Score.ToString ();
			winText.text = "YOU WIN";
			nextLevelIn.text = "Next Level IN";
			StartCoroutine (CDBRObugone());
			
	}

	void FixedUpdate () {

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);

		
		//float moveHorizontal = Input.GetAxis("Horizontal");
		//float moveVertical = Input.GetAxis("Vertical");

		//Vector3 moveVec = new Vector3 (CrossPlatformInputManager.GetAxis("Horizontal"), 0.0f,(CrossPlatformInputManager.GetAxis("Vertical")));

		//bool isJumping = CrossPlatformInputManager.GetButton ("Jump");

		//rb.AddForce (moveVec * speed);
	}

	public bool isGrounded;
	
	//void OnCollisionStay(Collision coll){
	//	isGrounded = true;
	//}
	//void OnCollisionExit(Collision coll){
	//	if(isGrounded){
	//		isGrounded = false;   
	//	}
	//}

	IEnumerator waitforanotherjump(){
		yield return new WaitForSeconds(0.1f);
		isGrounded = false;
	}

	void Update(){

		//if (Input.GetMouseButtonDown (0))
			//Jump ();


		rbPosition = transform.position;
		//Debug.Log(rbPosition);


		if(rbPosition.y < -2.0f){

			Application.LoadLevel(Application.loadedLevel);
			//checkpoint();
			//rbPosition = rb.position = new Vector3(0.0f,0.5f,0.0f);
		
		}

	}


	void checkpoint(){
		checkpoint1 ();
	}

	void checkpoint1(){
		rbPosition = transform.position = new Vector3(0f, 0.5f, 0f);
	}

	void checkpoint2(){
		transform.position = new Vector3(0f, 5f, 0f);
	}

	IEnumerator growback() {
		yield return new WaitForSeconds(5);
		
		GetComponent<Rigidbody>().transform.localScale += new Vector3(0.8f, 0.8f, 0.8f);
		GetComponent<Renderer>().material = greenBox;
	}
	IEnumerator ghostoff(){
		yield return new WaitForSeconds(5);

		GetComponent<Renderer>().material = greenBox;
	}

	void OnCollisionEnter(Collision collision){
	
		
		if (collision.gameObject.CompareTag ("terrain")) {

			isGrounded = true;

		}

		if (collision.gameObject.CompareTag ("redMorph")) {
			
			isGrounded = true;
			
		}
		if (collision.gameObject.CompareTag ("GBox")) {
			
			isGrounded = false;
			
		}
	}

	void OnTriggerEnter(Collider other) {

		
		if (other.gameObject.CompareTag ("checkpoint")) {
			checkpoint2 ();
		
		}

		if (other.gameObject.CompareTag ("pTrigger")) {
			pTriggerPanel.touchedTriggerPanel = true;
			destroyButton.destroyIt = true;
			
		}
		if (other.gameObject.CompareTag ("redpill")) {
			source.clip = PowerUpSound;
			source.Play ();
			other.gameObject.SetActive (false);
			GetComponent<Renderer>().material = redPill;

			GetComponent<Rigidbody>().transform.localScale -= new Vector3(0.8f, 0.8f, 0.8f);

			//StartCoroutine(growback());

		}


		if (other.gameObject.CompareTag ("bluepill")) {
			other.gameObject.SetActive (false);
			GetComponent<Renderer>().material = bluePill;
			Vector3 jump = new Vector3 (0.0f, 3000.0f, 0.0f);
			GetComponent<Rigidbody>().AddForce (jump);

			GetComponent<Rigidbody>().transform.localScale -= new Vector3(0.8f, 0.8f, 0.8f);

		}

		if (other.gameObject.CompareTag ("blackpill")) {
			other.gameObject.SetActive (false);
			GetComponent<Renderer>().material = blackPill;

			GetComponent<Rigidbody>().transform.localScale += new Vector3(2.0f, 2.0f, 2.0f);
		}
		if (other.gameObject.CompareTag ("brownpill")) {

			Destroy(GameObject.FindWithTag ("boxTrap")); 

			other.gameObject.SetActive (false);

			GetComponent<Renderer>().material = brownPill;

		}
		if (other.gameObject.CompareTag ("redButtonCannon")) {
			
			Destroy(GameObject.FindWithTag ("destroyFloor")); 
			
			//other.gameObject.SetActive (false);

			
		}
		if (other.gameObject.CompareTag ("redButton")) {
			source.clip = redButtonSound;
			source.Play ();
		}
		if (other.gameObject.CompareTag ("pTrigger")) {
			source.clip = redButtonSound;
			source.Play ();
		}
		if (other.gameObject.CompareTag ("GhostPill")) {
			
			source.clip = PowerUpSound;
			source.Play ();
			other.gameObject.SetActive (false);
			GetComponent<Renderer>().material = GhostPill;

			GhostCube.tookGhostPill = true;
			//StartCoroutine(ghostoff());
			
		}

		if (other.gameObject.CompareTag ("Gpill")) { 

			source.clip = PowerUpSound;
			source.Play ();

			other.gameObject.SetActive (false);
			Destroy(GameObject.FindWithTag ("planeTest")); 

			Gpill.tookGPill = true;
		}
		if (other.gameObject.CompareTag ("Gpill2")) { 
			
			source.clip = PowerUpSound;
			source.Play ();
			
			other.gameObject.SetActive (false);
			Destroy(GameObject.FindWithTag ("planeTest")); 

			
			Gpill2.tookGPill2 = true;
		}
		if (other.gameObject.CompareTag ("Gpill3")) { 
			
			source.clip = PowerUpSound;
			source.Play ();
			
			other.gameObject.SetActive (false);
			Destroy(GameObject.FindWithTag ("planeTest")); 

			
			Gpill3.tookGPill3 = true;
		}
		if (other.gameObject.CompareTag ("Gpill4")) { 
			
			source.clip = PowerUpSound;
			source.Play ();
			
			other.gameObject.SetActive (false);
			Destroy(GameObject.FindWithTag ("planeTest")); 

			
			Gpill4.tookGPill4 = true;
		}


		if (other.gameObject.CompareTag ("Cpill")) { 
			
			source.clip = PowerUpSound;
			source.Play ();
			
			GCube.tookCpill = true;

			
			other.gameObject.SetActive (false);
			Destroy(GameObject.FindWithTag ("planeTest")); 
			
			GetComponent<Renderer>().material = Cpill;
			
		}

		if (other.gameObject.CompareTag ("Jpill")) { 
			
			source.clip = PowerUpSound;
			source.Play ();

			other.gameObject.SetActive (false);

			GetComponent<Renderer>().material = Cpill;
			jump = new Vector3 (0.0f, 1000.0f, 0.0f);
			
		}

		if (other.gameObject.CompareTag ("greenBox")) {

			GetComponent<Renderer>().material = greenBox;
			GetComponent<Rigidbody>().transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
			speed = 15;

		}
		//Destroy(other.gameObject);

		//bouncy platform
		if (other.gameObject.CompareTag ("bouncyP2")) {
			Vector3 jump = new Vector3 (0.0f, 500.0f, 0.0f);
			GetComponent<Rigidbody>().AddForce (jump);
			
		}

		if (other.gameObject.CompareTag ("Bouncyp3")) {
			Vector3 jump = new Vector3 (0.0f, 0.0f, 6000.0f);
			GetComponent<Rigidbody>().AddForce (jump);
			
		}
		if (other.gameObject.CompareTag ("water")) {
			//Physics.gravity = new Vector3(-1.0f, -1.0f, 0.0f);
			
		}
		if (other.gameObject.CompareTag ("sonicPill")) {
			
			source.clip = redSound;
			source.Play ();

			other.gameObject.SetActive (false);
			speed = 50;
			GetComponent<Renderer>().material = sonicPill;

		}

		if (other.gameObject.CompareTag ("hulkPill")) {
			
			other.gameObject.SetActive (false);
			GetComponent<Renderer>().material = hulkPill;


			GetComponent<Rigidbody>().transform.localScale += new Vector3(3.0f, 3.0f, 3.0f);
			
		}

		if (other.gameObject.CompareTag ("score")) {
			
			other.gameObject.SetActive (false);
			Score = Score + 1;
			source.clip = collectingCoin;
			source.Play ();
			SetScoreText ();
			
		}
		if (other.gameObject.CompareTag ("scoreWin")) {
			other.gameObject.SetActive (false);
			Score = Score + 1;
			source.clip = collectingCoin;
			source.Play ();
			scoreWinCoin ();	

		}
		
	}

	public void stopSpin(){
		GetComponent<Animator>().SetTrigger ("changeState");
			
	}

	public void SetVertical (int i) {

		moveVertical = i;

	}
	public void SetHorizontal (int i) {
		
		moveHorizontal = i;
		
	}

	public void Jump () {

		if (isGrounded == true) {
			
			Vector3 jump = new Vector3 (0.0f, 600.0f, 0.0f);
			GetComponent<Rigidbody>().AddForce (jump);
			source.clip = jumpSound;
			source.Play ();
			StartCoroutine(waitforanotherjump());
		}

	}

}
