using UnityEngine;
using System.Collections;

public class scoreRotate : MonoBehaviour {
	public Rigidbody rb;

	void Start () {
		
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().transform.position += (new Vector3(0.25f, 0.0f, -0.45f) * Time.deltaTime);
	
	}
}
