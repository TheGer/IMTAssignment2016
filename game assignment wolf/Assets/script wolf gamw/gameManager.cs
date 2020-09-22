using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

    public int spawnTime;

    private int timer;
    
    

	// Use this for initialization
	void Start () {

       
        treeMaker();
       
      

	}
	
	// Update is called once per frame
	void Update () {


        timer++;

        if (timer >= spawnTime)
        {

            treeMaker();
            
            timer = 0; 
        }
	
	}



    
    
    void treeMaker(){

        Instantiate (Resources.Load ("AlanTree"));
            
    }
}

