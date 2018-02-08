using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float posZ = transform.position.z + Mathf.Cos(transform.position.z);
		transform.position = new Vector3(0, 0, posZ);
		print(transform.position.x);
	}
}
