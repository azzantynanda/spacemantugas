using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAbility : MonoBehaviour {
	public bool on1;
	public GameObject pilPelindung;
	public bool on2;
	public GameObject pilBom;
	public bool on3;
	public GameObject pilTriple;

	public int pelindungTime;
	int pelindungmini;
	public int bomTime;
	int bommini;
	public int tripleTime;
	int tripleini;
	// Use this for initialization
	void Start () {
		pelindungmini = pelindungTime;
		bommini = bomTime;
		tripleini=tripleTime;
	}
	
	// Update is called once per frame
	void Update () {
		counting();
		checekAll();
	}

	public void pelindungOn(){
		pilPelindung.SetActive(true);
		on1=true;
	}
	public void bomOn(){
		pilBom.SetActive(true);
		on2=true;
	}
	public void tripleOn(){
		pilTriple.SetActive(true);
		on3=true;
	}

	void checekAll(){
		if(pelindungmini<1){
			pilPelindung.SetActive(false);
			on1=false;
			pelindungmini=pelindungTime;
		}else if(bommini<1){
			pilBom.SetActive(false);
			on2=false;
			bommini=bomTime;
		}else if(tripleini<1){
			pilTriple.SetActive(false);
			on3=false;
			tripleini=tripleTime;
		}
	}

	void counting(){
		if(on1){
			pelindungmini -=1;
		}else if(on2){
			bommini -=1;
		}else if(on3){
			tripleini -= 1;
		}
	}
}
