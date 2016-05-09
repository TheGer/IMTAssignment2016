using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum Direction 
{
	Gas,Left,Right
}

public class ButtonController : MonoBehaviour {

	public void ButtonPressed (int dirNum)
	{
		Direction dir = (Direction)dirNum;
		CarController carccont = GameObject.FindObjectOfType<CarController> ();

		switch (dir)
		{
		case Direction.Gas:
			carccont.vertical = 1f;
			break;

		case Direction.Left:
			carccont.horizontal = -1f;
			break;

		case Direction.Right:
			carccont.horizontal = 1f;
			break;
		}
	}

	public void ButtononRelease (int dirNum)
	{
		Direction dir = (Direction)dirNum;
		CarController carccont = GameObject.FindObjectOfType<CarController> ();
		
		switch (dir)
		{
		case Direction.Gas:
			carccont.vertical = 0f;
			break;
			
		case Direction.Left:
		case Direction.Right:
			carccont.horizontal = 0f;
			break;
		}
	}

	public void StartButton()
	{
		Application.LoadLevel ("Level 1");
	}

	public void ControlsButton()
	{
		Application.LoadLevel ("controls");
	}
	public void RulesButton()
	{
		Application.LoadLevel ("rules");
	}

	public void HomeButton()
	{
		Application.LoadLevel ("main menu");
	}

	public void QuitButton()
	{
		Application.LoadLevel ("quit");
	}

	public void noButton()
	{
		Application.LoadLevel ("main menu");
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
