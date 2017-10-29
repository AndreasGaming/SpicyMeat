using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesPool : MonoBehaviour {

	public int objectPoolSize = 5;
	public GameObject pipesPrefab;
	public float spawnRate = 4f;
	public float pipeMin = -1f;
	public float pipeMax = 3.5f;

	private GameObject[] objectPool;
	private Vector2 objectPoolPosition = new Vector2 (-15f, -25f);
	private float timeSinceLastSpawned;
	public float spawnXposition = 15f;
	private int currentPipe = 0;

	// Use this for initialization
	void Start () 
	{
		objectPool = new GameObject[objectPoolSize];

		for (int i = 0; i < objectPoolSize; i++)
		{
			objectPool [i] = (GameObject)Instantiate (pipesPrefab, objectPoolPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {

		timeSinceLastSpawned += Time.deltaTime;

		if (GameMaster.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
		{
			timeSinceLastSpawned = 0;
			float spawnYposition = Random.Range (pipeMin, pipeMax);
			objectPool [currentPipe].transform.position = new Vector2 (spawnXposition, spawnYposition);
			currentPipe++;

			if (currentPipe >= objectPoolSize) 
			{
				currentPipe = 0;
			}
		}
	}
}
