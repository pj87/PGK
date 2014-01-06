using UnityEngine;
using System;
using System.Collections.Generic;

public class BuildWall2 : MonoBehaviour {
	
	public Transform brick;
	public Transform player;
	//To jest caly murek w 1 miejscu. CYA!
	List<Transform> lista = new List<Transform>(); 
	// Use this for initialization
	void Start () {
		/*
		for (int y = 0; y < 10; y++) {
			for (int x = 0; x < 5; x++) {
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.AddComponent<Rigidbody>();
				//cube.AddComponent<Animation>();
				//cube.AddComponent<MeshFilter>();
				//cube.AddComponent<MeshCollider>();
				//go.AddComponent<MyCustomScript>();
				//cube.AddComponent<MeshRenderer>();
				cube.transform.position = new Vector3(900 + x, y, 900);
			}
		}*/

			for (int y = 0; y < 5; y++) { 
				for (int x = 0; x < 5; x++) { 
					var tmp = Instantiate(brick, new Vector3(900 + x, y, 700), Quaternion.identity) as Transform;
				lista.Add(tmp);
			} 
		} 
	} 
	// Update is called once per frame
	void Update () {
	
		
		foreach (var item in lista) {
			item.transform.position = new Vector3(player.transform.position.x + 5, player.transform.position.y + 5, player.transform.position.z + 5); 
		}
		
		//player.transform.position.
	}
}
