using UnityEngine;
using System.Collections;

public class next : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.Space))
		{
			Application.LoadLevel(1);
		}

		if(Input.GetKeyDown (KeyCode.N))
		{
			Application.LoadLevel(2);
		}
	
	}
}
