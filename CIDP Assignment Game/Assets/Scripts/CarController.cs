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


	public AudioClip CollectingCoin;
	public AudioClip CollectingHealthPack;
	public AudioClip CarCrash;
	public AudioClip BatterySound;
	private AudioSource audioSource;

	void Awake () {

		carRB = GetComponent <Rigidbody> ();
		scoreGenerator = GetComponent <ScoreGenerator> ();
		audioSource = GetComponent <AudioSource> ();
	}


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


	void FixedUpdate () {

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		carRB.MovePosition (transform.position + ((Vector3.forward * v) + (Vector3.right * h )) * speed * Time.deltaTime);


		if (horizontal != 0 || vertical != 0)
			carRB.MovePosition (transform.position + ((Vector3.forward * vertical) + (Vector3.right * horizontal )) * speed * Time.deltaTime);


		scoreGenerator.Battery (-(batteryPerSecond * Time.fixedDeltaTime));

	}

}
