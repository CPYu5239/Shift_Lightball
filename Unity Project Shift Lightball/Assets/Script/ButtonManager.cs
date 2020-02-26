using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{


     public GameObject basicMovement;
     public GameObject basicMovement2;

    public void ShowBasicMovement1()
    {
        basicMovement.SetActive(true);
        basicMovement2.SetActive(false);

    }


    public void ShowBasicMovement2()
    {
        basicMovement.SetActive(false);
        basicMovement2.SetActive(true);

    }

    public void CloseBasicMovement2()
    {
      
        basicMovement2.SetActive(false);

    }
}
