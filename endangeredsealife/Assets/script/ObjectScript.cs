using UnityEngine;
using System.Collections;

public enum ObjectType {
	Health, Score, Boostpack, DamagingFallingMaterial, DamagingMovingMaterial
}

public class ObjectScript : MonoBehaviour {

	public ObjectType type;

}
