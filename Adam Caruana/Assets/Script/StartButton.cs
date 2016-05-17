using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

		public void OnMouseDown1()
		{
			Debug.Log(" ");
			AudioSource audio = GameObject.Find("SoundHolder").GetComponent<AudioSource>();
			audio.Play();
			SceneManager.LoadScene("Level1");
		}
		public void OnMouseDown2()
		{
			Debug.Log(" ");
			AudioSource audio = GameObject.Find("SoundHolder1").GetComponent<AudioSource>();
			audio.Play();
			SceneManager.LoadScene("Level2");
		}
		public void OnMouseDown3()
		{
			Debug.Log(" ");
			SceneManager.LoadScene("Level3");
		}
		public void OnMouseDown4()
		{
			Debug.Log(" ");
		SceneManager.LoadScene("instructions");
		}
		public void OnMouseDown5()
		{
			Debug.Log(" ");
			SceneManager.LoadScene("Start game");
		}
		public void Quit()
		{
			
			Application.Quit();
			Debug.Break();
		}
}
