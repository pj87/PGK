using UnityEngine;
using System.Collections;

public class CollisionWithCube : MonoBehaviour {

    void OnControllerColliderHit (ControllerColliderHit hit) 
    {
        if (hit.collider.gameObject.name == "Box")
        {
            Debug.Log("Collision!!!!!"); 
        } 
    } 

    /*
    void OnCollisionEnter(Collision collision) 
    {
        Debug.Log("Collision!!!!!"); 

        if( collision.gameObject.name == "Box" )
        {
            Destroy(collision.gameObject);
        }
    } 
    */ 
	
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
