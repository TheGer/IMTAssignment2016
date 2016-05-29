using UnityEngine;
using System.Collections;

public class Gpill2 : MonoBehaviour {

	public static bool tookGPill2 = false;
	public Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	IEnumerator tookgpill2nowtrue(){
		yield return new WaitForSeconds(2);
		bool tookGPill2 = false;
	}

	
	// Update is called once per frame
	void Update () {
		if(tookGPill2 == true){
			//rb.useGravity = true;
			rb.isKinematic = false;
			rb.AddForce(-100.0f,0.0f,0.0f);
			StartCoroutine (tookgpill2nowtrue());
			//Physics.gravity = new Vector3(-30.0f, 0.0f, 0.0f);
		}
		
	}
}
