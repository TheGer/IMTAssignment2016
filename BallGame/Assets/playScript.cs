using UnityEngine;
using System.Collections;

public class playScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayGame(){

		Application.LoadLevel (6);
	}

	public void ExitApp(){

		Application.Quit ();
	}

	public void mainMenu(){
		
		Application.LoadLevel (0);
	}

	public void tutorial(){

		Application.LoadLevel (1);
	}
	public void lvl1(){
		
		Application.LoadLevel (2);
	}
	public void lvl2(){
		
		Application.LoadLevel (3);
	}
	public void lvl3(){
		
		Application.LoadLevel (4);
	}
}
