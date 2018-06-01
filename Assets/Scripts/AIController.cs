using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour 
{
	private ShootLaser shootLaser;
	public bool canShoot;

	void Start () 
	{
		GameManager.instance.enemiesSpawned.Add (this.gameObject);
		shootLaser = GetComponent<ShootLaser> ();
	}

	void OnDestroy()
	{
		GameManager.instance.enemiesSpawned.Remove (this.gameObject);
	}

	void Update () 
	{
		if (canShoot == true) 
		{
			shootLaser.FireLaser ();
		}
	}
}
