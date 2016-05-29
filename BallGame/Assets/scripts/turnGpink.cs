using UnityEngine;
using System.Collections;

public class turnGpink : MonoBehaviour {
	public Rigidbody rb;
	public Material redPill;
	public Material bluePill;
	public Material pinkPill;
	public Material yellowPill;
	public Material blackPill;
	public Material[] myArray;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		myArray = new Material[5];

		myArray[0] =  redPill;
		myArray[1] = bluePill;
		myArray[2] = pinkPill;
		myArray[3] = yellowPill;
		myArray[4] = blackPill;

		int arraySize = myArray.Length;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {

		GetComponent<Renderer>().material = myArray[2];
		//GetComponent<Renderer>().material = myArray[Random.Range(0,4)];

	}
}
