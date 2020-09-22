using UnityEngine;
using System.Collections;

public class logmaker : MonoBehaviour
{

    public int spawnTime;

    private int timer;



    // Use this for initialization
    void Start()
    {


        logmaker1();



    }

    // Update is called once per frame
    void Update()
    {


        timer++;

        if (timer >= spawnTime)
        {

            logmaker1();

            timer = 0;
        }

    }





    void logmaker1()
    {

        Instantiate(Resources.Load("logs"));

    }
}

