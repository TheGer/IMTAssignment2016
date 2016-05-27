using UnityEngine;
using System.Collections;

public class redbutton : MonoBehaviour {
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag ("Player")) {
			GCube.tookCpill = true;
			GetComponent<Rigidbody>().transform.position += new Vector3(0f, -0.23f, 0f);
		}
	
	}
}
