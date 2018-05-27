using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour 
{
	public float p_moveSpeed;
	public int p_rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		moveForward ();
		rotate ();
	}

	void moveForward()
	{
		// This controls player forward movement
		transform.Translate (0, Time.deltaTime * p_moveSpeed * Input.GetAxis ("Vertical"), 0);
	}
	void rotate()
	{
		// This controls player rotation
		transform.Rotate (0, 0, Time.deltaTime * p_rotationSpeed * Input.GetAxis ("Horizontal"), 0);
	}
}

