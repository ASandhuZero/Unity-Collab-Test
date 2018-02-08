using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float posX = transform.position.z + 1;
		transform.position = new Vector3(0, 0, posX);
		print(transform.position.x);
	}
}
