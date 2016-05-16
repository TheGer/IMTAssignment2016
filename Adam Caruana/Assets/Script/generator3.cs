using UnityEngine;
using System.Collections;

public class generator3 : MonoBehaviour {
	public GameObject power1;
	public GameObject power2;
	public GameObject power3;
	public int numberOfobjects;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (makeobjects());
	}
	IEnumerator makeobjects()
	{
		int counter = 0;
		do {
			float xposition = Random.Range(-4f,4f)	;
			int objectChooser = Random.Range(1,20);
			counter++;
			
			if (objectChooser == 1)
			{
				Instantiate(power1,
				            new Vector3(xposition,6.5f,0),
				            Quaternion.identity);
			}if (objectChooser == 2)
			{
				Instantiate(power2,
				            new Vector3(xposition,6.5f,0),
				            Quaternion.identity);
			}if (objectChooser == 3)
			{
				Instantiate(power3,
					new Vector3(xposition,6.5f,0),
					Quaternion.identity);
			}
			counter++;
			yield return new WaitForSeconds(1f);
		}while(counter < numberOfobjects);{
		}
	}
}
