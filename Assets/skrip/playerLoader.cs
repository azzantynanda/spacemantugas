using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLoader : MonoBehaviour {
	public sistem dataS;
	public int jetEngine;
	public GameObject[] tipeJetnya;
	bool doLoop;
	int i=0;
	// Use this for initialization
	void Start () {
		dataS = GetComponent<sistem>();
		jetEngine = dataS.tipeJet;
	}
	
	// Update is called once per frame
	void Update () {
		if(!doLoop){
			Debug.Log("insoeksi");
		i = 0;
		while(i<tipeJetnya.Length){
			if(i == jetEngine){
				tipeJetnya[i].SetActive(true);
			}else{
				tipeJetnya[i].SetActive(false);
			}
			i++;
		}
			doLoop = true;
	}
	}
}
