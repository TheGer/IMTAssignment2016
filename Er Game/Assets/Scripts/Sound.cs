using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {

    // Use this for initialization
    public AudioClip myclip;

    // Use this for initialization
    public void heartsound()
    {
        // this code stores the audio source in it and when the user presses the button "play sound" it will play the sound 
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = myclip;
        this.GetComponent<AudioSource>().Play();
    }

    public void Intestines()
    {
        // this code stores the audio source in it and when the user presses the button "play sound" it will play the sound 
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = myclip;
        this.GetComponent<AudioSource>().Play();
    }

    public void Lungs()
    {
        // this code stores the audio source in it and when the user presses the button "play sound" it will play the sound 
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = myclip;
        this.GetComponent<AudioSource>().Play();
    }

    public void Stomach()
    {
        // this code stores the audio source in it and when the user presses the button "play sound" it will play the sound 
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = myclip;
        this.GetComponent<AudioSource>().Play();
    }

    public void eye()
    {
        // this code stores the audio source in it and when the user presses the button "play sound" it will play the sound 
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = myclip;
        this.GetComponent<AudioSource>().Play();
    }
}
