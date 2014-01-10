using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour { 

	// Use this for initialization 
	void Start () { 
	
	} 
	
	// Update is called once per frame 
	void Update () { 
	 
	} 
    /*
    void OnControllerColliderHit(ControllerColliderHit hit) 
    { 
        //if (hit.collider.gameObject.name == "qube(Clone)") 
        //{ 
            Debug.Log("Collision with other objects..."); 
        //} 
    } */

    void OnCollisionEnter(Collision collision) 
    { 
        //collision.collider.gameObject 
        Debug.Log("Collision with other objects..."); 
    } 
} 
