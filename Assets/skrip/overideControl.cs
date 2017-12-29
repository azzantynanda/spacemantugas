using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overideControl : MonoBehaviour {
	Done_PlayerController player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Done_PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void left(int nilai){
		Debug.Log("kiri");
		player.hx = nilai;
	}

	public void right(int nilai){
		Debug.Log("kanan");
		player.hx = nilai;
	}
	public void tembak(int nilai){
		if(nilai==1){
			player.fB=true;
		}else{
			player.fB = false;
		}
	}
}
