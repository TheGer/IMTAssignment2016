using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerController : MonoBehaviour 
{
	public float jumpheight;
	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement*speed);

		if (Input.GetKeyDown ("space") && GetComponent<Rigidbody>().transform.position.y <= 0.5f) {
			Vector3 jump = new Vector3 (0.0f, jumpheight, 0.0f);
			GetComponent<Rigidbody>().AddForce (jump);
		}
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("pickup"));
			 
		{
			other.gameObject.SetActive (false);
			count = count+1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();

		if (count >= 12) 
		{
			winText.text="You Win";
		}
	}
}
