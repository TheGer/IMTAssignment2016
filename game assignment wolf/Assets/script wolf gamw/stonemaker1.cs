using UnityEngine;
using System.Collections;

public class stonemaker1 : MonoBehaviour
{

    public int spawnTime;

    private int timer;



    // Use this for initialization
    void Start()
    {


        stone1maker();



    }

    // Update is called once per frame
    void Update()
    {


        timer++;

        if (timer >= spawnTime)
        {

            stone1maker();

            timer = 0;
        }

    }





    void stone1maker()
    {

        Instantiate(Resources.Load("stone3"));

    }
}

