#pragma strict

var sound : AudioClip;

function OnTriggerEnter(Col : Collider)
{
	if(Col.CompareTag("Player"))
	{
		GetComponent.<AudioSource>().PlayOneShot(sound);
	}	
}