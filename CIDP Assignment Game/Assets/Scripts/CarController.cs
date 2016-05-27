using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarController : MonoBehaviour {

	private Rigidbody carRB;
	private float speed = 35f;
	private ScoreGenerator scoreGenerator;
	private float batteryPerSecond = 1f;

	public float horizontal = 0f;
	public float vertical = 0f;

	public GameObject explosion;

	public AudioClip CollectingCoin;
	public AudioClip CollectingHealthPack;
	public AudioClip CarCrash;
	public AudioClip BatterySound;
	private AudioSource audioSource;

	public float minBounds;
	public float maxBounds;

	// the purpose of this function is to call out these particular components
	void Awake () {

		carRB = GetComponent <Rigidbody> ();
		scoreGenerator = GetComponent <ScoreGenerator> ();
		audioSource = GetComponent <AudioSource> ();

	}

	// this function is used so that the object tag can add the following commands listed for each object.
	void OnTriggerEnter(Collider other) {

		if (other.tag == "object") {

			ObjectType type = other.GetComponent <ObjectScript> ().type;

			switch (type) {

			case ObjectType.Coin:
				scoreGenerator.AddScore (1);
				audioSource.clip = CollectingCoin;
				audioSource.Play ();
				break;

			case ObjectType.HealthPack:
				scoreGenerator.AddHealth (1);
				audioSource.clip = CollectingHealthPack;
				audioSource.Play ();
				break;

			case ObjectType.OilBarrell:
				scoreGenerator.AddHealth (-1);
				audioSource.clip = CarCrash;
				audioSource.Play ();
				Instantiate (explosion, transform.position, Quaternion.identity);
				break;

			case ObjectType.Battery:
				scoreGenerator.Battery (10);
				audioSource.clip = BatterySound;
				audioSource.Play ();
				break;

			}

			Destroy (other.transform.parent.gameObject);

		}

	}

	// this is the function that is used to control the car movement to move horizontal and vertical
	void FixedUpdate () {

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		carRB.MovePosition (transform.position + ((Vector3.forward * v) + (Vector3.right * h )) * speed * Time.deltaTime);


		if (horizontal != 0 || vertical != 0)
			carRB.MovePosition (transform.position + ((Vector3.forward * vertical) + (Vector3.right * horizontal )) * speed * Time.deltaTime);

		if (transform.position.x < minBounds) {
			Vector3 pos = transform.position;
			pos.x = minBounds;
			transform.position = pos;
		}

		if (transform.position.x > maxBounds) {
			Vector3 pos = transform.position;
			pos.x = maxBounds;
			transform.position = pos;
		}

		scoreGenerator.Battery (-(batteryPerSecond * Time.fixedDeltaTime));

	}

}
