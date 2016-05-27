using UnityEngine;
using System.Collections;

public class next : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // the keydown is when i press the space bar it will load scene one

		if(Input.GetKeyDown (KeyCode.Space))
		{
			Application.LoadLevel(1);
		}

        // the keydown is when i press the n button it will load scene two

        if (Input.GetKeyDown (KeyCode.N))
		{
			Application.LoadLevel(2);
		}
	
	}
}
