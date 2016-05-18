using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wolfcontrols1 : MonoBehaviour
{

    public float speed;
    public static int Score = 0;
    public int Hp = 0;
    public int timeleft;

    public AudioClip CollectingPoints;
    public AudioClip CollectingHeath;
    public AudioClip CollectiongExtraTime;
    public AudioClip CollisionwithTree;
    public AudioClip CollisionwithLogs;
    public AudioClip buttonssounds;
    private AudioClip audioSource;

   



    


    public Text ShowScore;
    public Text ShowHP;
    public Text ShowTime;

    private AudioSource audio;

   


    void Awake()
    {
        audio = GetComponent<AudioSource>();

    }

    void FixedUpdate()
    {

        ShowScore.text = "Score: " + Score;
        ShowHP.text = "Health: " + Hp;
        ShowTime.text = "Time: " + timeleft; 
       



    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DmgDealer")
        {
            Hp -= 10;

            audio.clip = CollisionwithTree;
            audio.Play();

        }

        if (other.gameObject.tag == "obsticle")
        {
            Hp -= 10;

            audio.clip = CollisionwithTree;
            audio.Play();

        }





        if (other.gameObject.tag == "Score_Pickup")
        {
            Destroy(other.gameObject);
            Score += 10;

            audio.clip = CollectingPoints;
            audio.Play();

        }

        if (other.gameObject.tag == "HP_Pickup")
        {
            Destroy(other.gameObject);
            Hp += 5;

            audio.clip = CollectingHeath;
            audio.Play();
        }

        if (other.gameObject.tag == "timepickup")
        {
            Destroy(other.gameObject);
            GameObject.FindObjectOfType<Timer>().ExtendTime(25);

            audio.clip = CollectiongExtraTime;
            audio.Play();
        }



    }

    void Update()
    {
        if (Hp <= 0f)
        {
            SceneManager.LoadScene("gameoverlives0");
        }


        //if the game has been running longer than length of game

        float mouseX;

        //mouse position
        mouseX = Input.mousePosition.x;



        Vector3 platePosition;

        platePosition = Camera.main.ScreenToWorldPoint(
            new Vector3(mouseX, 0, 10f));

        Debug.Log(platePosition);

        //to keep the y position of the plate, we only use the X
        transform.position =
            new Vector3(platePosition.x, transform.position.y, 0);
        //////
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 40 * Time.deltaTime, Space.World);
        }
        
         if (Input.GetButtonDown("Fire1"))//onclick
        {
            transform.Translate(Vector3.up *  50 * Time.deltaTime, Space.World); 
        }
        if (Input.GetButton("Fire2"))// if button is held the character will keep on flying 
        {
            transform.Translate(Vector3.up * 10 * Time.deltaTime, Space.World);
        }


        ///////
    }
   

}