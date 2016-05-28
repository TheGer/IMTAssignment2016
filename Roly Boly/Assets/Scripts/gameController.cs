using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	public int spawnTime;
	private int timer;
	private int timer2;
	private int timer3;
	private int timer4;
	
	// Use this for initialization
	void Start () {

		CubeFunction();
	}
	
	// Update is called once per frame
	void Update () {
	
		timer++;
		timer2++;
		timer3++;
		timer4++;

		if (timer >= spawnTime) {
			CubeFunction();
			timer = 0;
		}
		
		if (timer2 >= spawnTime * 10) {
			CoinFunction();
			timer2 = 0;
		}
		
		if (timer3 >= spawnTime * 22) {
			MinusFunction();
			timer3 = 0;
		}
		
		if (timer4 >= spawnTime * 25) {
			PlusFunction();
			timer4 = 0;
		}
	}

	void CubeFunction() {
		Instantiate (Resources.Load ("cube"));
	}
	
	void CoinFunction() {
		Instantiate (Resources.Load ("coin"));
	}
	
	void MinusFunction() {
		Instantiate (Resources.Load ("minus"));
	}
	
	void PlusFunction() {
		Instantiate (Resources.Load ("plus"));
	}
}
