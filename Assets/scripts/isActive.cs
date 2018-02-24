using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isActive : MonoBehaviour {


    public bool active = false;
  


	// Use this for initialization
	void Start () {

        

        

	}
	
	// Update is called once per frame
	void Update () {
		
        if (active == true)
        {
            if (Input.GetMouseButton(0))
            {
                
                Renderer rend = GetComponent<Renderer>();
                rend.material.shader = Shader.Find("Standard");
                rend.material.SetColor("_Color", Color.green);
            }
                       

        }


	}
}
