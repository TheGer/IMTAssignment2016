using UnityEngine;
using System.Collections;

public class clockspawner : MonoBehaviour
{

    public int spawnTime;

    private int timer;



    // Use this for initialization
    void Start()
    {


        clockspawn();



    }

    // Update is called once per frame
    void Update()
    {


        timer++;

        if (timer >= spawnTime)
        {

            clockspawn();

            timer = 0;
        }

    }





    void clockspawn()
    {

        Instantiate(Resources.Load("Clock"));

    }
}

