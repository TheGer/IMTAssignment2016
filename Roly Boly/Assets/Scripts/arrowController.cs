using UnityEngine;
using System.Collections;


public class arrowController : MonoBehaviour {
    
	public static float directionValue;
    

	public void LeftButtonPressed ()
	{

		directionValue = -1;


		Debug.Log (directionValue);



	}



	public void RightButtonPressed ()
	{

		directionValue = 1;

		Debug.Log (directionValue);



	}


}
