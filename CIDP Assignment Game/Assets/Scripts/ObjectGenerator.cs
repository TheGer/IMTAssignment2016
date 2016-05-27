using UnityEngine;
using System.Collections;

public class ObjectGenerator : MonoBehaviour {

	public GameObject[] objects;
	public Transform car;
	public int maxObjects;

	public float distance = 20f;

	
	void Start () {
		
		StartCoroutine ("GenerateObject");
	}
	
	//this function generates the objects in a random manner within a fixed parameter
	IEnumerator GenerateObject () {
		
		while (GameObject.FindGameObjectsWithTag ("object").Length < maxObjects) {
			GameObject target = objects [Random.Range (0, objects.Length)];
			
			Vector3 pos = car.position;
			pos.x = Random.Range (-6f, 6f);
			pos.z += distance;
			
			GameObject item = (GameObject)Instantiate (target, pos, Quaternion.identity);
			
			yield return new WaitForSeconds (1.5f);
		}
	}
	
}