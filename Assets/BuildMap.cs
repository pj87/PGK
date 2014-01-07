using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class BuildMap : MonoBehaviour {

    public Transform brick;
    //public Transform player1;

    public GameObject player;  

    //var player : GameObject; 

    //To jest caly murek w 1 miejscu. CYA!
    List<Transform> lista = new List<Transform>();

    void buildMap(Vector3 position) 
    { 
        for (int x = 0; x < 25; x++) 
        { 
            for (int y = 1; y < 2; y++) 
            { 
                for (int z = 0; z < 5; z++) 
                { 
                    var tmp = Instantiate(brick, new Vector3(position.x + x, y, position.z + z), Quaternion.identity) as Transform; 
                    if (z == 0 || z == 4) 
                    { 
                        var tmp1 = Instantiate(brick, new Vector3(position.x + x, y + 1, position.z + z), Quaternion.identity) as Transform; 
                        var tmp2 = Instantiate(brick, new Vector3(position.x + x, y + 2, position.z + z), Quaternion.identity) as Transform; 
                        lista.Add(tmp1); 
                        lista.Add(tmp2); 
                    } 
                    lista.Add(tmp); 
                } 
            }
        } 
    } 

	// Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player"); 
        buildMap(new Vector3(900, 0, 700)); 
    } 
	
	// Update is called once per frame
	void Update () {

        //var playerPos:Vector3 = Player.transform.position 

        if (player.transform.position.x > 924 && player.transform.position.z > 702) 
        //if (player.position.x > 924 && player.position.z > 702) 
        {
            Debug.Log("Dziala!!!!!");
            //buildMap(new Vector3(900, a, 702));
            //a++; 
        } 
	}
}
