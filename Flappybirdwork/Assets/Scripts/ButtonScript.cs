﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

	public void StartGame(int sceneIndex){
	
		SceneManager.LoadScene (sceneIndex);
	}

	public void QuitGame(){

		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif 
		Application.Quit ();

	}
}