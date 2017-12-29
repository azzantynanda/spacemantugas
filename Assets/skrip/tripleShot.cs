using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tripleShot : MonoBehaviour {
	public GameObject shot;
	public Transform[] shotSpawn;
	public float fireRate;

	private float nextFire;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextFire){
		nextFire = Time.time + fireRate;
		Instantiate(shot, shotSpawn[0].position, shotSpawn[0].rotation);
		Instantiate(shot, shotSpawn[1].position, shotSpawn[1].rotation);
		GetComponentInParent<AudioSource>().Play ();
		}
	}
}
