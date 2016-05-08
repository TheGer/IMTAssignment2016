using UnityEngine;
using System.Collections;

public class platformController : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		speed = 10;
	}

	void Update () {
		transform.Translate (-speed * (Time.deltaTime / 2), 0, 0);

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("rightLimit")) {
			speed = speed - (speed * 2);
		}

		if (other.gameObject.CompareTag ("leftLimit")) {

			speed = speed + (-speed * 2);
		}
	}
}
