using UnityEngine;
using System.Collections;

public class destroyButton : MonoBehaviour {
	public static bool destroyIt = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (destroyIt == true) {
		
			Destroy(gameObject);
		}
	}
}
