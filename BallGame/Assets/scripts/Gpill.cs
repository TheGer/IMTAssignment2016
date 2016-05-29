using UnityEngine;
using System.Collections;

public class Gpill : MonoBehaviour {
	public static bool tookGPill = false;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	IEnumerator tookgpillnowtrue(){
		yield return new WaitForSeconds(2);
		bool tookGPill = false;
	}

	// Update is called once per frame
	void Update () {
		if(tookGPill == true){
			//rb.useGravity = true;
			rb.isKinematic = false;
			rb.AddForce(-100.0f,0.0f,0.0f);
			StartCoroutine (tookgpillnowtrue());
			//Physics.gravity = new Vector3(-30.0f, 0.0f, 0.0f);
		}
	
	}
}
