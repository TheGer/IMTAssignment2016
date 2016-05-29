using UnityEngine;
using System.Collections;

public class HelpController : MonoBehaviour {

    // this code is basically to load the help scenes when the help button is pressed

    public GameObject healthPanel;

    public void HelpHeart()
    {
        healthPanel.SetActive(true);
    }


    public void BackButton()
    {
        healthPanel.SetActive(false);
    }


    public void HelpOrgans()
    {
        healthPanel.SetActive(true);
    }


    public void HelpLungs()
    {
        healthPanel.SetActive(true);
    }


    public void Helpstomach()
    {
        healthPanel.SetActive(true);
    }



    public void HelpBrain()
    {
        healthPanel.SetActive(true);
    }


    public void Helpeye()
    {
        healthPanel.SetActive(true);
    }

    public void Helptooth()
    {
        healthPanel.SetActive(true);
    }


    public void Helpspinal()
    {
        healthPanel.SetActive(true);
    }


    public void HelpSkull()
    {
        healthPanel.SetActive(true);
    }


    public void HelpRib()
    {
        healthPanel.SetActive(true);
    }


}
