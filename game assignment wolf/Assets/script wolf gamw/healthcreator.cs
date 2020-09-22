using UnityEngine;
using System.Collections;

public class healthcreator : MonoBehaviour
{

    public int spawnTime;

    private int timer;



    // Use this for initialization
    void Start()
    {


        healthspawn();



    }

    // Update is called once per frame
    void Update()
    {


        timer++;

        if (timer >= spawnTime)
        {

            healthspawn();

            timer = 0;
        }

    }





    void healthspawn()
    {

        Instantiate(Resources.Load("health"));

    }
}

