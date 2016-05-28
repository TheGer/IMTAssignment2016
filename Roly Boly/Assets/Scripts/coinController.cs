using UnityEngine;
using System.Collections;

public class coinController : MonoBehaviour {

	public Vector3 spawnPoint;
	public int speed;
	private Transform camPos;
	private int ranXPos = Random.Range (-4,5);

	// Use this for initialization
	void Start () {
		
		transform.position = new Vector3(ranXPos,spawnPoint.y,spawnPoint.z);
		camPos = GameObject.Find ("Main Camera").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position += Vector3.back * speed * 0.5f;
		
		transform.Rotate (new Vector3 (0, 90, 0) * Time.deltaTime);
		
	}
}
