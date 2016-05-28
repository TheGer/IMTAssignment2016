using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayTotalScore : MonoBehaviour {
	public Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText.text = string.Format ("Your total score is: {0}", State.TotalScore);
	}	

}
