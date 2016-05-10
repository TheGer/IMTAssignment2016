using UnityEngine;
using System.Collections;

public class coinspawner : MonoBehaviour
{

    public int spawnTime;

    private int timer;



    // Use this for initialization
    void Start()
    {


        coinspawn();



    }

    // Update is called once per frame
    void Update()
    {


        timer++;

        if (timer >= spawnTime)
        {

            coinspawn();

            timer = 0;
        }

    }





    void coinspawn()
    {

        Instantiate(Resources.Load("coin"));

    }
}

