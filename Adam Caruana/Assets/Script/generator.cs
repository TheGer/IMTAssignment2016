using UnityEngine;
using System.Collections;

public class generator : MonoBehaviour {
	public GameObject Trashcan;
	public GameObject tincan;
	public GameObject tincan2;
	public int numberOfobjects;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (makeobjects());
	}
	void OnGUI(){
		GUI.color = Color.black;
		GUI.Label (new Rect (10, 10, 150, 50), "Collect the Tin Cans");
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
				Instantiate(tincan,
				            new Vector3(xposition,6.5f,0),
				            Quaternion.identity);
			}if (objectChooser == 2)
			{
				Instantiate(tincan2,
				            new Vector3(xposition,6.5f,0),
				            Quaternion.identity);
			}if (objectChooser == 3)
			{
				Instantiate(Trashcan,
					new Vector3(xposition,6.5f,0),
					Quaternion.identity);
			}
			counter++;
			yield return new WaitForSeconds(1f);
		}while(counter < numberOfobjects);{
		}
	}
}
