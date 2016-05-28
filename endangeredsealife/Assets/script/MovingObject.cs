using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

	private SpriteRenderer sRenderer;
	private float alpha = 1f;
	private float fadeAmount = 2f;
	private bool isFading = false;

	void Awake () {

		sRenderer = GetComponent <SpriteRenderer> ();

	}


	void OnBecameInvisible () {

		Destroy (gameObject);

	}


	void Update () {

		transform.LookAt (Camera.main.transform.position);

		if (isFading) {

			alpha -= fadeAmount * Time.deltaTime;
			sRenderer.color = new Color (1f, 1f, 1f, alpha);

			if (alpha <= 0f)
				Destroy (gameObject);

		}

	}


	public void Animate () {

		isFading = true;

	}

}
