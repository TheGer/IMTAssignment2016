using UnityEngine;
using System.Collections;

public class Controller1 : MonoBehaviour {
	public GameObject player;
	public int force = 0;

	public void moveleft(){
		AudioSource audio = GameObject.Find("SoundHolder2").GetComponent<AudioSource>();
		audio.Play();
		player.transform.Translate(-Vector3.right * 20 * Time.deltaTime);
	}

	public void moveright(){
		AudioSource audio = GameObject.Find("SoundHolder2").GetComponent<AudioSource>();
		audio.Play();
		player.transform.Translate(Vector3.right * 20 * Time.deltaTime);
	}
	public void jump(){
		AudioSource audio = GameObject.Find("SoundHolder2").GetComponent<AudioSource>();
		audio.Play();
		StartCoroutine (makeobjects());
	}
	IEnumerator makeobjects()
	{
		int counter = 0;
		do {
			player.transform.Translate(Vector3.back * 700 );
			counter++;
			yield return new WaitForSeconds(1f);
		}while(counter == 0);{
			player.transform.Translate(Vector3.forward * 700 );
		}
	}
}
