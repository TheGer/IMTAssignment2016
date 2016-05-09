using UnityEngine;
using System.Collections;

public enum ObjectType {
	Coin, HealthPack, Battery, OilBarrell
}

public class ObjectScript : MonoBehaviour {

	public ObjectType type;

	void OnBecameInvisible () {

		Destroy (transform.parent.gameObject);

	}
}
