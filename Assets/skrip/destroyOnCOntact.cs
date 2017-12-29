using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCOntact : MonoBehaviour {
	public enum Tipe{Pelindung, Bom, Triple};
	public Tipe tipenya;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.CompareTag("Player")){
			playerAbility player = col.gameObject.GetComponent<playerAbility>();
			if(tipenya==Tipe.Pelindung){
				if(!player.on1){
					player.pelindungOn();
				}
			}else if(tipenya==Tipe.Bom){
				if(!player.on2){
					player.bomOn();
				}
			}else if(tipenya==Tipe.Triple){
					if(!player.on3){
						player.tripleOn();
					}
				}
			Destroy(gameObject);
		}
	}

}
