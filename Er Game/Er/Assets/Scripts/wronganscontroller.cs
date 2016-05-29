using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wronganscontroller : MonoBehaviour
{
    public GameObject ANS4;
 //  public void OnEnable()
 //   {
 //       ANS4.SetActive(true);
 //   }

   public void OnDisable()
    {
        ANS4.SetActive(false);
    }
}

