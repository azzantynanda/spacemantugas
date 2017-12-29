﻿using UnityEngine;
using System.Collections;

public class Done_DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private Done_GameController gameController;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <Done_GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Boundary" || other.tag == "Enemy")
		{
			return;
		}

		if (explosion != null)
		{
			Instantiate(explosion, transform.position, transform.rotation);
		}

		if (other.tag == "Player")
		{
			hpPlayer hp = other.gameObject.GetComponent<hpPlayer>();
			if(hp.hp>0){
				hp.demagedByContact(scoreValue);
			}else{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver();
			Destroy (other.gameObject);
			}
		}

		gameController.AddScore(scoreValue);
		//Destroy (gameObject);
	}
}