using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
	public GameObject[] enemiesList;
	public Transform[] spawnPoints;
	public List<GameObject> enemiesSpawned;
	public static GameManager instance;

	public int playerLives;

	private int randomSpawn;
	private int randomNum;

	// Use this for initialization
	void Start () 
	{

	}

	void Awake ()
	{
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		} 
		else 
		{
			Destroy (this.gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
		// This will control the number of enemies spawned
		if (enemiesSpawned.Count < 3)
		{
			randomSpawn = Random.Range (0, spawnPoints.Length);
			randomNum = Random.Range(0,9);
			// Spawn enemies
			Instantiate (enemiesList[randomNum], spawnPoints[randomSpawn].position, spawnPoints[randomSpawn].rotation);
		}
	}
}
