using UnityEngine;
using System.Collections;

public class SpinningAnimator2 : MonoBehaviour {

    public void stopButton()
    {

        GameObject.Find("lungs").GetComponent<Animator>().SetTrigger("changestate2");
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
            GetComponent<Animator>().SetTrigger("changestate2");

        }

    }
}
