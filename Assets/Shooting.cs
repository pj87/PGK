using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Shooting : MonoBehaviour
{
    public GameObject bullet; 
    public Vector3 speed; 
    public GameObject player; 

    List<Rigidbody> lista = new List<Rigidbody>(); 

    // Use this for initialization 
	void Start () { 
        player = GameObject.Find("3rd Person Controller"); 
        //player.transform.position. 
	} 
	
	// Update is called once per frame
	void Update () { 
        if (Input.GetKeyDown(KeyCode.LeftControl)) 
        { 
            //var b = Instantiate(bullet, new Vector3(player.transform.position.x, player.transform.position.y + 1.0f, player.transform.position.z), Quaternion.identity) as Rigidbody;

            //var b = Instantiate(bullet, player.transform.position, Quaternion.identity) as Rigidbody;

            //bullet

            //var b = Instantiate(bullet.GetComponent<Rigidbody>(), player.transform.position, player.transform.rotation) as Rigidbody;

            var b = (GameObject)Instantiate(bullet, player.transform.position, Quaternion.identity) as GameObject; 

            b.transform.Rotate(new Vector3(90, player.transform.rotation.eulerAngles.y, 180)); 
            b.AddComponent<Rigidbody>(); 

            //b.GetComponent<Rigidbody>().useGravity = false;

            b.rigidbody.useGravity = false;
            b.rigidbody.mass = 0.1f; 
            //b.rigidbody.isKinematic = true;
            //b.rigidbody.velocity = new Vector3(0.0f, 200.0f, 1.0f); 
            //b.rigidbody.velocity = new Vector3(0.0f, 200.0f, 1.0f); 
            b.rigidbody.AddForce(player.transform.forward * 8000);

            //Debug.DrawLine(Vector3.zero, b.transform.forward, Color.red);

            //b.GetComponent<Rigidbody>().isKinematic = false; 
            //b.GetComponent<Rigidbody>().velocity = new Vector3(1.0f, 0.0f, 1.0f); 
            //b.GetComponent<Rigidbody>().mass = 1.0f; 
            //b.GetComponent<Rigidbody>().AddForce(b.transform.forward * 8); 
            //b.GetComponent<Rigidbody>().AddForce(new Vector3(1.0f, 0.0f, 0.0f)); 
            //b.GetComponent<Rigidbody>().velocity = new Vector3(0.1f, 0.0f, 0.0f); 

            //shotRapid.rigidbody.AddForce(); 

            //b.GetComponent<Rigidbody>().velocity = new Vector3(1.0f, 0.0f, 1.0f); 

            //b.transform.eulerAngles = player.transform.rotation.eulerAngles; 

            //b.velocity = transform.TransformDirection(Vector3.forward * 1.0f); 

            //b.velocity = new Vector3(1.0f, 0.0f, 1.0f); 

            //b.AddComponent<Rigidbody>();

            //Rigidbody bRigidBody = b.AddComponent<Rigidbody>();
            //b.rigidbody.velocity = player.transform.rotation.eulerAngles.normalized * 1.0f; 
            
            //b.Translate()
            /* 
            Debug.Log("-----------------------------------------"); 
            Debug.Log(player.transform.rotation);
            Debug.Log(player.transform.rotation.eulerAngles);
            Debug.Log("-----------------------------------------"); 
            */ 
            //b.transform.Rotate(new Vector3(player.transform.rotation.eulerAngles.x, 0, player.transform.rotation.eulerAngles.z)); 
            //b.transform.Rotate(new Vector3(180, 0, 270)); 
            //b.transform.Rotate(new Vector3(player.transform.rotation.eulerAngles.x, 0, player.transform.rotation.eulerAngles.z)); 
            //b.transform.rotation = player.transform.rotation; 
            //lista.Add(b); 
            //var tmp1 = Instantiate(bullet, new Vector3(player.transform.position), Quaternion.identity) as Transform; 
            //var tmp1 = Instantiate(bullet, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity) as Transform; 
        } 
	} 
} 
