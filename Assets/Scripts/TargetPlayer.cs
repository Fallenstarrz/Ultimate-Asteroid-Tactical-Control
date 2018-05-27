using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayer : MonoBehaviour 
{
	public float enemyRotationSpeed;
	private Transform player;
	public bool tracking;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find ("PlayerCharacter").transform;
		TargetInstantly ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (tracking == true) 
		{
			TargetDelayed ();
		}
	}

	void TargetInstantly()
	{
		Vector3 dir = player.position - transform.position;
		dir.Normalize ();
		float zAngle = (Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg - 90);
		transform.rotation = Quaternion.Euler (0, 0, zAngle);
	}
	void TargetDelayed()
	{
		Vector3 dir = player.position - transform.position;
		dir.Normalize ();
		float zAngle = (Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg - 90);
		Quaternion targetLocation = Quaternion.Euler (0, 0, zAngle);
		transform.rotation = Quaternion.RotateTowards (transform.rotation, targetLocation, enemyRotationSpeed * Time.deltaTime);
	}
}
