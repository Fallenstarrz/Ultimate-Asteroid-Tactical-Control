﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour 
{
	public float lifespan;

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, lifespan);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
