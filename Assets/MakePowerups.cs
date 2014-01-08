using UnityEngine;
using System.Collections;

public class MakePowerups : MonoBehaviour {

    public Transform powerup; 

	// Use this for initialization
	void Start () {
	    for (int z = 0; z < 5; z++) {
            for (int x = 0; x < 5; x++)
            {
                var tmp = Instantiate(powerup, new Vector3(910 + x, 1.5f, 640 + z), Quaternion.identity) as Transform;
            } 
	    } 
    } 
	
	// Update is called once per frame
	void Update () {
	
	}
}
