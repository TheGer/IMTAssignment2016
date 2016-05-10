using UnityEngine;
using System.Collections;

public class scoreDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	void OnGUI()
	{
		GUI.Label (new Rect (100, 60, 100, 1001), "Level 1: "+PlayerPrefs.GetInt("level1score"));
		GUI.Label (new Rect (100, 90, 100, 1001),"Level 2: "+PlayerPrefs.GetInt("level2score"));
		GUI.Label (new Rect (100, 120, 100, 1001),"Level 3: "+PlayerPrefs.GetInt("level3score"));
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
