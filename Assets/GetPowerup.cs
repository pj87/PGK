using UnityEngine;
using System.Collections;

public class GetPowerup : MonoBehaviour {

    void OnControllerColliderHit(ControllerColliderHit hit) 
    { 
        if (hit.collider.gameObject.name == "powerup(Clone)") 
        { 
            Debug.Log("Get powerup!!!!!");
            Destroy(hit.collider.gameObject); 
        } 
    } 

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
