using UnityEngine;
using System.Collections;

public class hover : MonoBehaviour {

	Vector3 temp;
	public float speed;

	void Start () {

		//basically transform the poisition of an object instantly (may use in future dunno)

		//Vector3 temp = transform.position;
		//temp.x -= 5f;
		//transform.position = temp;


	}	


	void Update () {
		transform.Translate (-speed * (Time.deltaTime / 2), 0, 0);

	}

	void OnTriggerEnter(Collider other) {
			if (other.gameObject.CompareTag ("leftInvWall")) {

			//GetComponent<Rigidbody>().transform.Translate (0f, 6 * Time.deltaTime, 0);

			speed = speed - (speed * 2);
			}

		if (other.gameObject.CompareTag ("rightInvWall")) {
			
			speed = speed + (-speed * 2);
		}
	}
}
