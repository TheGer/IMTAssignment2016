using UnityEngine;
using System.Collections;

public class CarCamera : MonoBehaviour {

	private Vector3 offset;
	public Transform car;

	void Awake () {

		offset = transform.position - car.position;

	}

	void LateUpdate () {

		transform.position = car.position + offset;

	}

}
