using UnityEngine;
using UnityEngine.SceneManagement;
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
            SceneManager.LoadScene(1);
		}

        // the keydown is when i press the n button it will load scene two

        if (Input.GetKeyDown (KeyCode.N))
		{
            SceneManager.LoadScene(2);
		}
	
	}
}
