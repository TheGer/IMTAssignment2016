using UnityEngine;
using System.Collections;

public class generator2 : MonoBehaviour {
	public GameObject box;
	public GameObject cone;
	public GameObject trashcan1;
	public int numberOfobjects;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (makeobjects());
	}
	void OnGUI(){
		GUI.color = Color.black;
		GUI.Label (new Rect (10, 10, 250, 50), "Collect the cones and boxes");
	}
	IEnumerator makeobjects()
	{
		int counter = 0;
		do {
			float xposition = Random.Range(-4f,4f)	;
			int objectChooser = Random.Range(1,4);
			counter++;
			
			if (objectChooser == 1)
			{
				Instantiate(box,
				            new Vector3(xposition,6.5f,0),
				            Quaternion.identity);
			}if (objectChooser == 2)
			{
				Instantiate(cone,
				            new Vector3(xposition,6.5f,0),
				            Quaternion.identity);
			}if (objectChooser == 3)
			{
				Instantiate(trashcan1,
					new Vector3(xposition,6.5f,0),
					Quaternion.identity);
			}
			counter++;
			yield return new WaitForSeconds(1f);
		}while(counter < numberOfobjects);{
		}
	}
}
