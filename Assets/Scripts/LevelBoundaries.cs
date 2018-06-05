using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundaries : MonoBehaviour 
{

	// Use a trigger box as level bounds, if anything with tags player or enemy leave then destroy them
	void OnTriggerExit2D (Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "Enemy") 
		{
			Destroy(other.gameObject);
		}
	}
}
