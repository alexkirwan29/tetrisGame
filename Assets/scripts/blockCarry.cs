using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blockCarry : MonoBehaviour
{

    

    public Image defaultCrossfair;
    public Image canPickupCrosshair;

    public GameObject testCube;
    public isActive isActiveScript;

    public int distanceFromPlayer = 10;

    // Use this for initialization
    void Start()
    {
        

        isActiveScript = Object.FindObjectOfType<isActive>();
       
    
    }

    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1))
        {
            if (hit.collider.tag == "intable")
            {
               // defaultCrossfair.enabled = false;
               // canPickupCrosshair.enabled = true;
                isActiveScript.active = true;
                


            }
        }

            //if (Input.GetMouseButton(0))
          //  {                           
           //     defaultCrossfair.enabled = true;
           //     canPickupCrosshair.enabled = false;
           // }       

    }

}

