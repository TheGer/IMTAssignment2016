using UnityEngine;
using System.Collections;

public class SpinningAnimator8 : MonoBehaviour {

    public void stopButton()
    {

        GameObject.Find("skull").GetComponent<Animator>().SetTrigger("changestate8");
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // set the trigger when you press space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("changestate8");

        }

    }
}
