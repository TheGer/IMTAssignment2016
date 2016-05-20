using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ballController : MonoBehaviour {

	public float speed;
	public float jumpHeight;
	public bool isFalling;
	private Rigidbody rb;
	public float score;
	public float lengthOfGame;
	float startTime;
	public Text scoreText;
	public int jumpTimer;
	public bool firstJump;
	public float horizontal = 0f;
	
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		isFalling = false;
		firstJump = true;
		
		startTime = Time.time;
	}

	void Update()
	{
		jumpTimer++;
		horizontal = 0;
		if ((jumpTimer > 600 || firstJump) && ((Input.GetMouseButtonDown(1) && isFalling == false ) || (Input.GetKey("up") && isFalling == false)))
		{
			Vector3 jump = new Vector3 (0.0f, jumpHeight, 0.0f);
			GetComponent<Rigidbody>().AddForce (jump);
			
			jumpTimer = 0;
			isFalling = true;
			firstJump = false;
		}

		if(gameObject.transform.position.y <= -5)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
			
		if ((Time.time - startTime) > lengthOfGame) 
		{
			int i = Application.loadedLevel;
			Application.LoadLevel(i + 1);

			scoreScript.myHighScore += score;
		}
		
		score += Time.deltaTime;
		UpdateUI ();
	}
	
	void FixedUpdate()
	{
	   //move object with keys	
        //float moveHorizontal = Input.GetAxis ("Horizontal");

        //move object with buttons
        float moveHorizontal = arrowController.directionValue;
        
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);

		rb.AddForce (movement * speed);

		moveHorizontal = 0f;
		arrowController.directionValue = 0f;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("base"))
		{
			isFalling = false;
		} 
		
		if(other.tag == "cube") 
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		
		if(other.tag == "coin") 
		{
			score += 10;
			UpdateUI ();
			Destroy (GameObject.FindWithTag("coin"));
		}
		
		if(other.tag == "minus")
		{
			GetComponent<Rigidbody>().transform.localScale -= new Vector3(0.1f,0.1f,0.1f);
			Destroy (GameObject.FindWithTag("minus"));
		}
		
		if(other.tag == "plus")
		{
			GetComponent<Rigidbody>().transform.localScale += new Vector3(0.1f,0.1f,0.1f);
			Destroy (GameObject.FindWithTag("plus"));
		}
	}
	
	void UpdateUI () {
		scoreText.text = string.Format ("Score: {0}", (int) score);
	}
	
}
