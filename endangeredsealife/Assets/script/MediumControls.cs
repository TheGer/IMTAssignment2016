using UnityEngine;
using System.Collections;

    public enum Direction 
    {
       Up,Down,Left,Right
    }

public class MediumControls : MonoBehaviour {
    
    public void ButtonPressed (int dirNum)
	{
		Direction dir = (Direction)dirNum;
		Control fishcontrol = GameObject.FindObjectOfType<Control> ();

		switch (dir)
		{
            case Direction.Up:
                fishcontrol.vertical = 1f;
                break;

            case Direction.Down:
                fishcontrol.vertical = -1f;
                break;

            case Direction.Left:
                fishcontrol.horizontal = -1f;
                break;

            case Direction.Right:
                fishcontrol.horizontal = 1f;
                break;
		}
	}

	public void ButtononRelease (int dirNum)
	{
		Direction dir = (Direction)dirNum;
		Control fishcontrol = GameObject.FindObjectOfType<Control> ();
		
		switch (dir)
		{
            case Direction.Up:
                fishcontrol.vertical = 0f;
                break;

            case Direction.Down:
                fishcontrol.vertical = 0f;
                break;	

            case Direction.Left:
            case Direction.Right:
                fishcontrol.horizontal = 0f;
                break;
		}
	}

}
