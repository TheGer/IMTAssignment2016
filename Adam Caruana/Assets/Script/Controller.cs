using UnityEngine;
using System.Collections;

public class cannonController : MonoBehaviour {
	float speed;
	void Start(){
		speed = Random.Range (1f, 3f);
	}
	
	void Update () {
		transform.Translate (Vector3.down * speed *Time.deltaTime);
		
		if (transform.position.y < -6){
			Destroy(this.gameObject);
		}
		
	}
}
