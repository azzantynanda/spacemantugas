using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpEnemy : MonoBehaviour {
	public float hp;
	public float value;
	public GameObject explosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		death();	
	}
	public void decreaseHP(float amount){
		hp-=amount;
	}

	void death(){
		if(hp<0){
			Instantiate(explosion, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
}
