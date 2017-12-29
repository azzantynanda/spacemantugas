using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decreaseEnemy : MonoBehaviour {
	public string tagEnemy;

	// Use this for initialization
	void Start () {
	}
		
	void OnTriggerEnter(Collider col){
		if(col.gameObject.CompareTag(tagEnemy)){
			Debug.Log("Trigerred");
			hpEnemy hp = col.gameObject.GetComponent<hpEnemy>();
			if(hp!=null){
				Debug.Log("Found one");
				hp.decreaseHP(hp.value);
				Destroy(gameObject);
			}
		}
	}
}