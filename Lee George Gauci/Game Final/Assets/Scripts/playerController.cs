using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class playerController : MonoBehaviour {

	public float speed;
	public float speedBoost;
	float growSize = 2f;
	float shrinkSize = 0.5f;
	float normalSize = 1f;

	public float jumpHeight;
	public float megaJumpHeight;

	private int count;
	private Rigidbody rb;
	private AudioSource source;

	public bool isFalling;
	public bool hasGrown;
	public bool hasShrunk;
	public bool hasSpeadUp;
	public bool megaJump;
	public bool canMove;

	public Text countText;
	public Text winText;
	public Text collectAll;

	public AudioClip pickUpSound;
	public AudioClip restartLevel;
	public AudioClip bgMusic;
	public AudioClip breakingBox;
	public AudioClip megaJumpSound;
	public AudioClip JumpSound;
	public AudioClip powerUpSound;

	void Start ()
	{
		SetCountText ();

		count = 0;

		winText.text = "";
		collectAll.text = "";

		isFalling = false;
		hasGrown = false;
		megaJump = false;
		canMove = true;

		rb = GetComponent<Rigidbody>();
		source = GetComponent<AudioSource>();
	}


	void Update ()
	{
		CanMove ();
		if (Input.GetMouseButtonDown(1) && isFalling == false && megaJump == false) 
		{
			source.PlayOneShot(JumpSound);
			Vector3 jump = new Vector3 (0.0f, jumpHeight, 0.0f);
			GetComponent<Rigidbody>().AddForce (jump);
			isFalling = true;
			canMove = false;

		}else if (Input.GetMouseButtonDown(1) && isFalling == false &&  megaJump == true)
		{
			source.PlayOneShot(megaJumpSound);
			GetComponent<Animator>().SetTrigger("megaJump");
			Vector3 jump = new Vector3 (0.0f, megaJumpHeight, 0.0f);
			GetComponent<Rigidbody>().AddForce (jump);
			isFalling = true;
			megaJump = false;
			canMove = false;
		}
	}

	void CanMove()
	{
		if (canMove == true) 
		{
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");
			
			Vector3 movement = new Vector3 (CrossPlatformInputManager.GetAxis("Horizontal"), 0.0f, (CrossPlatformInputManager.GetAxis("Vertical")));
			
			rb.AddForce (movement*speed);
		}

		if (canMove == true) 
		{
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (Input.GetAxis ("Horizontal"), 0.0f, Input.GetAxis ("Vertical"));

			rb.AddForce (movement*speed);
		}
	}

	void FixedUpdate ()
	{


		if (GetComponent<Rigidbody> ().transform.position.y <= -0.5f) // if component falls lower than -0.5 in the y axis than do this :
		{  

			//returns ball to starting position
			//gameObject.FindGameObjectsWithTag("shrink").gameObject.SetActive (true);
			//GameObject.FindGameObjectsWithTag("shrink").GetComponent<Rigidbody>.enable();
			//Destroy (gameObject);
			//Application.LoadLevel(0);
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 39) 
		{
			winText.text = "You can now Collect the final Oil Can";
		}

	}


	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("breakablebox")) {
			Destroy (other.gameObject, 1.2f);
			source.PlayOneShot(breakingBox);
			Vector3 jump = new Vector3 (0.0f, jumpHeight, 0.0f);
			GetComponent<Rigidbody> ().AddForce (jump);

			isFalling = false;
			canMove = false;
		}
			
		if (other.gameObject.CompareTag ("platform") ) 
		{
			isFalling = false;
			canMove = true;
			megaJump = false;
		} 

		if (other.gameObject.CompareTag ("lava") ) 
		{
			Destroy (gameObject, 5);
		} 


		if (other.gameObject.CompareTag ("base") ) 
		{
			isFalling = false;
			canMove = true;
			megaJump = false;
		} 

		if (other.gameObject.CompareTag ("megajump") && megaJump == false) 
		{
			megaJump = true;
			canMove = true;
			isFalling = false;
		} 

		if (other.gameObject.CompareTag ("breakableWall") && hasGrown == true)
		{
			other.gameObject.SetActive (false); //hide other object
		}

		if (other.gameObject.CompareTag ("pickup")) 
		{
			source.PlayOneShot(pickUpSound);
			other.gameObject.SetActive (false); //hide other object
			count = count + 1; // 1 point to the score 
			SetCountText (); //run the SetCountText Function
		}

		if (other.gameObject.CompareTag ("grow")) 
		{
			source.PlayOneShot(powerUpSound);
			hasGrown = true;
			other.gameObject.SetActive (false); //hide other object
			StartCoroutine(powerUps()); // run the IEnumerator
		}

		if (other.gameObject.CompareTag ("shrink")) 
		{
			source.PlayOneShot(powerUpSound);
			hasShrunk = true;
			other.gameObject.SetActive (false); //hide other object
			StartCoroutine(powerUps()); // run the IEnumerator
		}

		if (other.gameObject.CompareTag ("speed"))
		{
			source.PlayOneShot(powerUpSound);
			hasSpeadUp = true;
			other.gameObject.SetActive (false); //hide other object
			StartCoroutine(powerUps()); // run the IEnumerator
		}

		if (other.gameObject.CompareTag ("finalPickup")) 

		{
			
			if (count >= 39) 
			{
				other.gameObject.SetActive (false);
				Vector3 jump = new Vector3 (0.0f, 5000, 0.0f);
				GetComponent<Rigidbody> ().AddForce (jump);
			}
				
			if (count < 40) 
			{
				collectAll.text = "You need to collect all other cans first!";
			}
		}

		if (other.gameObject.CompareTag ("changeLevel")) 

		{
			Application.LoadLevel(2);
		}

		if (other.gameObject.CompareTag ("restartLevel")) 

		{
			source.PlayOneShot(restartLevel);
			gameObject.transform.localPosition = new Vector3 (7, 15, 166);

		}
	}

	public void jumpPressed()
	{
		CanMove ();
		if (isFalling == false && megaJump == false) 
		{
			source.PlayOneShot(JumpSound);
			Vector3 jump = new Vector3 (0.0f, jumpHeight, 0.0f);
			GetComponent<Rigidbody>().AddForce (jump);
			isFalling = true;
			canMove = false;

		}else if (isFalling == false &&  megaJump == true)
		{
			source.PlayOneShot(megaJumpSound);
			GetComponent<Animator>().SetTrigger("megaJump");
			Vector3 jump = new Vector3 (0.0f, megaJumpHeight, 0.0f);
			GetComponent<Rigidbody>().AddForce (jump);
			isFalling = true;
			megaJump = false;
			canMove = false;
		}
	}


	IEnumerator powerUps()
	{

		if (hasGrown == true)
		{
			GetComponent<Animator>().SetTrigger("grow");
			yield return new WaitForSeconds (3);
			GetComponent<Animator>().SetTrigger("returnToNormal2");
			yield return new WaitForSeconds (1);
			GetComponent<Animator>().SetTrigger("Idle");
			hasGrown = false;
		}

		if (hasShrunk == true)
		{
			GetComponent<Animator>().SetTrigger("shrink");
			yield return new WaitForSeconds (10);
			GetComponent<Animator>().SetTrigger("returnToNormal");
			yield return new WaitForSeconds (1);
			GetComponent<Animator>().SetTrigger("Idle");
			hasShrunk = false;
		}

		if (hasSpeadUp == true)
		{
			speed = speed + speedBoost;
			yield return new WaitForSeconds (3);
			speed = speed - speedBoost;
			hasSpeadUp = false;
		}

	}

}

