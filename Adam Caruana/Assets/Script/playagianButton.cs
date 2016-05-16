using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class playagianButton : MonoBehaviour {
	void OnMouseDown()
	{
		Debug.Log(" ");
		SceneManager.LoadScene(0);
	}
	
}