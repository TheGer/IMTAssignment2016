using UnityEngine;
//1.
using UnityEngine.UI;
using System.Collections;

public class buttonmanager : MonoBehaviour
{
    public Animation animation;

    //code which is triggered when the button is pressed


    // code which  is triggerd when the next button is pressed 
    public void mainmenutogameselection()
    {
        Application.LoadLevel("levelselection");
       

    }
    // code which is triggered when the previosu button is pressed
    public void levelslectioneasy()
    {
        Application.LoadLevel("gamewolflevel1");
    }


    public void stopSpinningButtonPressed()
    {
        GetComponent<Animator>().SetTrigger("run");
    }


    public void runifButtonPressed()
    {
        GetComponent<Animator>().SetTrigger("run");
    }

    public void levelselectionhard()
    {
        Application.LoadLevel("gamewolflevel2");
    }
    public void levelselectionnightmare()
    {
        Application.LoadLevel("gamewolflevel3");
    }
    public void backtomainmenu()
    {
        Application.LoadLevel("mainmenuwolfgame");
    }
    public void controlsbutton()
    {
        Application.LoadLevel("instructionsPCorsmartphone");
    }
    public void pcinstructionsbutton()
    {
        Application.LoadLevel("pccontrols");
    }
    public void viewyourcharacter()
    {
        Application.LoadLevel("test");
    }
    public void smartphoneinstructions()
    {
        Application.LoadLevel("phonecontrols1");
    }

    public void smartphoneinstructionspage2()
    {
        Application.LoadLevel("phonecontrols2");
    }
    public void firstpage()
    {
        Application.LoadLevel("scene1");
    }

    public void nextpage()
    {
        Application.LoadLevel("");

    
    }

    public void clickexit()
    {
        Application.Quit(); 

    } 

   


}
