using UnityEngine;
using System.Collections;

public class platforms : MonoBehaviour {

	public float speed;
	
	void Update () {
		transform.Translate (0, 0, speed * Time.deltaTime);
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("frontStop")) {
			
			//GetComponent<Rigidbody>().transform.Translate (0f, 6 * Time.deltaTime, 0);
			
			speed = speed - (speed * 2);
		}
		
		if (other.gameObject.CompareTag ("backStop")) {
			
			speed = speed + (-speed * 2);
		}
	}

}
