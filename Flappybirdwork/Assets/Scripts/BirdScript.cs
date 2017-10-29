using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

	public float upforce = 200f;

	private bool isDead;
	private Rigidbody2D rb2d;
	private Animator myAnimatior;

	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
		myAnimatior = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isDead == false) 
		{
			if (Input.GetMouseButtonDown (0) || Input.GetKeyDown(KeyCode.Space)) 
			{
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0, upforce));
				myAnimatior.SetTrigger ("Flap");
			}
		}

	}


	public void OnCollisionEnter2D()
	{
		rb2d.velocity = Vector2.zero;
		isDead = true;
	    GetComponentInChildren<ParticleSystem>().Play();
		GameMaster.instance.PlayerDied ();
	}
}
