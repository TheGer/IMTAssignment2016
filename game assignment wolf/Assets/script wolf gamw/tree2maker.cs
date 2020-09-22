using UnityEngine;
using System.Collections;

public class tree2maker : MonoBehaviour
{

    public int spawnTime;

    private int timer;



    // Use this for initialization
    void Start()
    {


        treeMaker2();



    }

    // Update is called once per frame
    void Update()
    {


        timer++;

        if (timer >= spawnTime)
        {

            treeMaker2();

            timer = 0;
        }

    }





    void treeMaker2()
    {

        Instantiate(Resources.Load("oak-a"));

    }
}

