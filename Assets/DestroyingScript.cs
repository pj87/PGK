using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class DestroyingScript : MonoBehaviour {

    //public GameObject shots;
    private List<GameObject> list; 

	// Use this for initialization
	void Start () {
        //shots = GameObject.Find("Shots"); 
        list = GetComponent<Shooting>().lista; 
        
        foreach (GameObject bullet in list) 
        {
            Debug.Log("Bullet: " + bullet); 
            //if (bullet.onC)
        } 
        //shots.GetComponent("list").get
        //list = (List<GameObject>)shots.GetComponent("Lista"); 
        //shots.GetComponent<List<GameObject>>()
	} 
	
	// Update is called once per frame
	void Update () {
	    
	}
}
