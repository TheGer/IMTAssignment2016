using UnityEngine;
using System.Collections;

public class lift : MonoBehaviour {
	public float speed;

	void Update () {
		transform.Translate (0, speed * Time.deltaTime, 0);
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("liftStop")) {
			
			//GetComponent<Rigidbody>().transform.Translate (0f, 6 * Time.deltaTime, 0);
			
			speed = speed - (speed * 2);
		}
		
		if (other.gameObject.CompareTag ("planeLift")) {
			
			speed = speed + (-speed * 2);
		}
	}
}
