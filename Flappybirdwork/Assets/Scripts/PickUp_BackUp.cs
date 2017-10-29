using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_BackUp : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col){

		Destroy (gameObject);

	}

}
