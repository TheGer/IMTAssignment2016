using UnityEngine;
using System.Collections;

public class GameBonusController : MonoBehaviour
{

    public GameObject apple;
    public GameObject beercan;
    public GameObject plustime;

    public int numberOfObjects;

    // Use this for initialization
    void Start()
    {

        StartCoroutine(makeobjects());


    }


    IEnumerator makeobjects()
    {
        int counter = 0;
        do
        {
            float xposition = Random.Range(-8f, 8f);
            //chooses a number from 1 till 4


            int objectChooser = Random.Range(1, 4);


            if (objectChooser == 1)
            {

                //make a apple
                Instantiate(apple, new Vector3(xposition, 10.5f, 0), Quaternion.identity);

            }


            if (objectChooser == 2)
            {

                //make a beercan
                Instantiate(beercan, new Vector3(xposition, 8.5f, 0), Quaternion.identity);

            }

            if (objectChooser == 3)
            {

                //make a starfish
                Instantiate(plustime, new Vector3(xposition, 6.5f, 0), Quaternion.identity);

            }

            counter++;
            //will wait one second and then create something 
            //else
            yield return new WaitForSeconds(2f);
        } while (counter < numberOfObjects);


    }

}
