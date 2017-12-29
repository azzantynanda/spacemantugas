using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomPoin : MonoBehaviour {
	Done_GameController kontroller;
	public int value;
	// Use this for initialization
	void Start () {
		kontroller = GameObject.FindGameObjectWithTag("GameController").GetComponent<Done_GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.CompareTag("Enemy")){
			kontroller.AddScore(value);
			Destroy(col.gameObject);
		}
	}
}
