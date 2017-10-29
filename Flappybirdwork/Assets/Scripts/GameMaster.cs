using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

	public static GameMaster instance;
	public GameObject gameOverText;
	public Text scoreText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;

	private int score = 0;

	// Use this for initialization
	 void Awake () 
	{
	    instance = this;
	} 
	
	// Update is called once per frame
	void Update () 
	{
		if (gameOver == true && Input.GetMouseButtonDown (0) || gameOver == true && Input.GetKeyDown(KeyCode.Space)) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
		}
	}

	public void PlayerScored()
	{
		if (gameOver) 
		{
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString ();
	}

	public void PlayerDied()
	{
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
