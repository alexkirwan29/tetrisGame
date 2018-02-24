using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemIDassigner : MonoBehaviour {

    public int noOfItems = 0;

    public List<GameObject> III = new List<GameObject>(); //III = Interable Items Index


	// Use this for initialization
	void Start () {

        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("intable"))
        {
            III.Add(fooObj);
            noOfItems = +1;
            
        }


    }
	
	// Update is called once per frame
	void Update () {

        




	}
}
