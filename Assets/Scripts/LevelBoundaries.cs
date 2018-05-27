using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundaries : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

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
