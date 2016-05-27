using UnityEngine;
using System.Collections;

public class pTriggerPanel : MonoBehaviour {

	public static bool touchedTriggerPanel = false;
	private Rigidbody rb;

	void Start (){
		
		rb = GetComponent<Rigidbody> ();

	}
	// Update is called once per frame
	void Update () {

		if (touchedTriggerPanel == true) {

			rb.isKinematic = false;
			rb.detectCollisions = false;
			transform.Translate (0, 0,10*Time.deltaTime);
			Destroy(gameObject, 4f);
		
		}
	
	}
}
