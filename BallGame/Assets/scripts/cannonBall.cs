using UnityEngine;
using System.Collections;

public class cannonBall : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		Destroy(gameObject, 4f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//void OnTriggerEnter(Collider other) {

		//if (other.gameObject.CompareTag ("bouncyP2")) {
		//	Vector3 fire = new Vector3 (0.0f, 0.0f, 5000.0f);
		//	GetComponent<Rigidbody> ().AddForce (fire);
		
		//}
	//}
}
