using UnityEngine;
using System.Collections;

public class grassspawner : MonoBehaviour
{

    public int spawnTime;

    private int timer;



    // Use this for initialization
    void Start()
    {


        grassspawn1();



    }

    // Update is called once per frame
    void Update()
    {


        timer++;

        if (timer >= spawnTime)
        {

 grassspawn1();

            timer = 0;
        }

    }





    void grassspawn1()
    {

        Instantiate(Resources.Load("grass"));

    }
}

