using UnityEngine;
using System.Collections;


public class animationplayer : MonoBehaviour {

	public void playani()
	{
		GameObject.Find ("Tin can").GetComponent<Animator>().SetTrigger("change");
		GameObject.Find ("Tin2").GetComponent<Animator> ().SetTrigger ("change1");
		GameObject.Find ("Trashcan2").GetComponent<Animator>().SetTrigger("change2");
		GameObject.Find ("Pipe").GetComponent<Animator>().SetTrigger("change3");
		GameObject.Find ("Plank (broken)").GetComponent<Animator>().SetTrigger("change4");
		GameObject.Find ("Pallet broken 1").GetComponent<Animator>().SetTrigger("change5");
		GameObject.Find ("Big box open 2").GetComponent<Animator>().SetTrigger("change6");
		GameObject.Find ("Traffic cone (bent)").GetComponent<Animator>().SetTrigger("change7");
		GameObject.Find ("Sphere").GetComponent<Animator>().SetTrigger("change8");


	}

}
