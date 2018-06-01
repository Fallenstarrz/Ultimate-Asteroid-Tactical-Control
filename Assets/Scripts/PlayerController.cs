using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	public float playerMoveSpeed;
	public float playerRotationSpeed;
	public Vector2 playerStartPosition;
	private ShootLaser shootLaser;

	void Start () 
	{
		// When object is constructed set it's position to the designer defined startPosition
		transform.position = playerStartPosition;
		shootLaser = GetComponent<ShootLaser> ();
	}

	void Update () 
	{
		moveForward ();
		rotate ();
		fireLaser ();
	}

	// decrease playerLives by 1 on destroy
	void OnDestroy()
	{
		GameManager.instance.playerLives -= 1;
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

