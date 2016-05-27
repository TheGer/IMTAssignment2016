using UnityEngine;
using System.Collections;

public class KillWhenFinished : MonoBehaviour {

	void Start () {
		Invoke ("Kill", 2f);
	}

	
	void Kill () {
		Destroy (gameObject);
	}
}
