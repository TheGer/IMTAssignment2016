using UnityEngine;
using System.Collections;

public class redButtonCannon : MonoBehaviour {
	private Rigidbody rb;
	public Rigidbody prefab;
	public Transform cannonBallSpawn;
	
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.CompareTag ("Player")) {
			Destroy(GameObject.FindWithTag ("lock")); 

			GetComponent<Rigidbody>().transform.position += new Vector3(0f, -0.60f, 0f);

				//for (int i = 0; i < 10; i++){
			Rigidbody prefabInstance;
			prefabInstance = Instantiate(prefab, cannonBallSpawn.position, cannonBallSpawn.rotation) as Rigidbody;
			prefabInstance.AddForce(cannonBallSpawn.forward * 5000);

			StartCoroutine(wait());


		}

	}

	IEnumerator wait() {
		yield return new WaitForSeconds(2);
		
		GetComponent<Rigidbody>().transform.position += new Vector3(0f, +0.60f, 0f);
	}
}
