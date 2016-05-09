using UnityEngine;
using System.Collections;

public class SpinningAnimator6 : MonoBehaviour {

    public void stopButton()
    {

        GameObject.Find("Brain").GetComponent<Animator>().SetTrigger("changestate6");
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
            GetComponent<Animator>().SetTrigger("changestate6");

        }

    }
}
