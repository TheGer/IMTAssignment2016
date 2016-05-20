using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showScoreScript : MonoBehaviour {

	public Text highScoreText;

	void Start ()
	{
		highScoreText.text = string.Format ("Final score: {0}", (int) scoreScript.myHighScore);
	}
}
