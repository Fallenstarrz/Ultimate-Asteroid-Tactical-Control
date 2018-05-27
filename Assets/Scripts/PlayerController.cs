using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	public float playerMoveSpeed;
	public float playerRotationSpeed;
	public Vector2 playerStartPosition;
	private ShootLaser shootLaser;

	// Use this for initialization
	void Start () 
	{
		// When object is constructed set it's position to the designer defined startPosition
		transform.position = playerStartPosition;
		shootLaser = GetComponent<ShootLaser> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		moveForward ();
		rotate ();
		fireLaser ();
	}

	// This controls player forward movement
	void moveForward()
	{
		transform.Translate (0, Time.deltaTime * playerMoveSpeed * Input.GetAxis ("Vertical"), 0);
	}

	// This controls player rotation
	void rotate()
	{
		transform.Rotate (0, 0, Time.deltaTime * playerRotationSpeed * Input.GetAxis ("Horizontal"), 0);
	}

	// We will fire a laser here
	void fireLaser()
	{
		if (Input.GetButton ("Fire1")) 
		{
			shootLaser.FireLaser ();
		}
	}
}

