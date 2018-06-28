﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour {

	public float jetpackForce = 75.0f;
	private Rigidbody2D playerRigidBody;

	// Use this for initialization
	void Start () 
	{
		playerRigidBody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		bool jetpackActive = Input.GetButton("Fire1");

		if(jetpackActive)
		{
			playerRigidBody.AddForce(new Vector2(0, jetpackForce));
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
