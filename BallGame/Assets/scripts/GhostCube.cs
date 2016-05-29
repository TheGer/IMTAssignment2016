using UnityEngine;
using System.Collections;

public class GhostCube : MonoBehaviour {

	public static bool tookGhostPill = false;
	public Rigidbody rb;
	
	void Start (){
		
		rb = GetComponent<Rigidbody> ();
	}

	IEnumerator ghostoff(){
		yield return new WaitForSeconds(5);
		rb.isKinematic = true;
		rb.detectCollisions = true;

	}
	
	// Update is called once per frame
	void Update () {
		if(tookGhostPill == true)
		{
			//notworking below
			//yield return new WaitForSeconds(5);
			
			
			//transform.Rotate(new Vector3(0,0,45) * (3 * Time.deltaTime));
			
			//rb.useGravity = true;
			rb.isKinematic = false;
			rb.detectCollisions = false;

			//StartCoroutine(ghostoff());
			//Physics.gravity = new Vector3(-1.0f, -1.0f, 0.0f);
			//rb.AddForce(1 * Physics.gravity);

		}
		
	}
}
