using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class Shooting : MonoBehaviour
{
    public Transform bullet; 
    public Vector3 speed; 
    public GameObject player; 

    List<Transform> lista = new List<Transform>(); 

    // Use this for initialization 
	void Start () { 
        player = GameObject.Find("3rd Person Controller"); 
        //player.transform.position. 
	} 
	
	// Update is called once per frame
	void Update () { 
        if (Input.GetKeyDown(KeyCode.LeftControl)) 
        { 
            var tmp = Instantiate(bullet, new Vector3(player.transform.position.x, player.transform.position.y + 1.0f, player.transform.position.z), Quaternion.identity) as Transform;
            lista.Add(tmp); 
            //var tmp1 = Instantiate(bullet, new Vector3(player.transform.position), Quaternion.identity) as Transform; 
            //var tmp1 = Instantiate(bullet, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity) as Transform; 
        } 
	} 
} 
