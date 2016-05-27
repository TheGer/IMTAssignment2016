using UnityEngine;
using System.Collections;

public class GameBonusController : MonoBehaviour
{

    public GameObject hearts;
    public GameObject lungs;
    public GameObject intestines;

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

                //creates a heart in the starting postion of 10.5f, 0 .
                Instantiate(hearts, new Vector3(xposition, 10.5f, 0), Quaternion.identity);

            }


            if (objectChooser == 2)
            {

                //creates a lung in the starting postion of 8.5f, 0 .
                Instantiate(lungs, new Vector3(xposition, 8.5f, 0), Quaternion.identity);

            }

            if (objectChooser == 3)
            {

                //creates a intestine in the starting postion of 6.5f, 0 .
                Instantiate(intestines, new Vector3(xposition, 6.5f, 0), Quaternion.identity);

            }

            counter++;
            //will wait two second and then create another object 
            yield return new WaitForSeconds(2f);
        } while (counter < numberOfObjects);


    }

}
