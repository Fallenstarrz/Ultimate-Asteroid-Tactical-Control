using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour 
{
	private ShootLaser shootLaser;
	public bool canShoot;

	// Use this for initialization
	void Start () 
	{
		shootLaser = GetComponent<ShootLaser> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (canShoot == true)
		{
			shootLaser.FireLaser ();
		}
	}
}
