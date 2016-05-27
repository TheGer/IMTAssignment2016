using UnityEngine;
using System.Collections;

public class GCube : MonoBehaviour {

	public static bool tookCpill = false;
	public Rigidbody rb;
	public Material redPill;

	void Start (){
		
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if(tookCpill == true)
		{
			//notworking below
			//yield return new WaitForSeconds(5);


			//transform.Rotate(new Vector3(0,0,45) * (3 * Time.deltaTime));

			rb.useGravity = true;
			rb.isKinematic = false;
			//Physics.gravity = new Vector3(-1.0f, -1.0f, 0.0f);
			//rb.AddForce(1 * Physics.gravity);
			GetComponent<Renderer>().material = redPill;
		}
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("water")) {

			// gravity uplift test
			rb.AddForce(100 * -Physics.gravity);


		}

	}
}
