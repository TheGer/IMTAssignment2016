using UnityEngine;
using System.Collections;

public class FallingObject : MonoBehaviour {


	public AnimationClip animation;

	private float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * speed * Time.deltaTime);
	}

	void OnBecameInvisible () {
		Destroy (gameObject);
	}

	public void Animate()
	{
		
	}

}
