using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

	public GameObject player;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
	
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	
	}
	void Update(){

		//transform.position = Camera.main.ScreenToViewportPoint;
	}
}
