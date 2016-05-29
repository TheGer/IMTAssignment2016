using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CollerController : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
	
	}

        void OnTriggerEnter(Collider otherObject)
    {

        Score score = GameObject.FindObjectOfType<Score>();

        if (otherObject.tag == "Heart")
        {
            //score goes up by one when Heart
            score.addscore();
            if (gameObject != null)
            {
                Destroy(otherObject.gameObject);
            }
        }
        if (otherObject.tag == "Lungs")
        {
            //score goes up by one when Lungs
            score.addscore();
            if (gameObject != null)
            {
                Destroy(otherObject.gameObject);
            }
        }
        if (otherObject.tag == "Intestines")
        {
            //score goes up by one when Intestines
            score.addscore();
            if (gameObject != null)
            {
                Destroy(otherObject.gameObject);
            }
        }

    }

    // Update is called once per frame
    void Update () {

        
    
            float mouseX;

            //mouse position
            mouseX = Input.mousePosition.x;
            Vector3 cooler;
            cooler = Camera.main.ScreenToWorldPoint(new Vector3(mouseX, 0, 10f));

            Debug.Log(cooler);

            //to keep the y position of the ice cooler, we only use the X
            transform.position = new Vector3(cooler.x, transform.position.y, 0);

        

    }
}
