using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

	public Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText.text = string.Format ("Your score is: {0}", State.CurrentScore);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
