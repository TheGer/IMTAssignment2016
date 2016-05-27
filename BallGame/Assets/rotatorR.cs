using UnityEngine;
using System.Collections;

public class rotatorR : MonoBehaviour {

	// Use this for initialization
	void Update () {
		transform.Rotate(new Vector3(45,30,15) * Time.deltaTime);
		
	}
}
