using UnityEngine;
using System.Collections;

public class ObjectGenerator : MonoBehaviour {

	public GameObject[] objects;
	public Transform fish;
	public int maxObjects;

	void Start () {

		StartCoroutine (GenerateObject());
	}

	IEnumerator GenerateObject () {

		while (true) {
			if (GameObject.FindGameObjectsWithTag ("object").Length < maxObjects) {

				GameObject target = objects [Random.Range (0, objects.Length)];
				Vector3 pos = fish.position;

				var objectType = target.GetComponent<ObjectScript> ().type;
				if (objectType == ObjectType.DamagingFallingMaterial) {
					pos.y = 0;
					pos.x = Random.Range (-5f, 11f);

					GameObject item = (GameObject)Instantiate (target, pos, Quaternion.identity);
					item.transform.parent = transform;
				} 
				else 
				{
					pos.y = Random.Range (-7f, 0f);
					GameObject item = (GameObject)Instantiate (target, pos, Quaternion.identity);
					item.transform.RotateAround (transform.position, Vector3.up, -40f);
					item.transform.parent = transform;
				}
			}

			yield return new WaitForSeconds (1f);
		}
	}

}
