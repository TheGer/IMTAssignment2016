using UnityEngine;
using System.Collections;

public class SpinningAnimator9 : MonoBehaviour {

    public void stopButton()
    {

        GameObject.Find("rib").GetComponent<Animator>().SetTrigger("changestate9");
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
            GetComponent<Animator>().SetTrigger("changestate9");

        }

    }
}
