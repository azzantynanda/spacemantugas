using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skripMainMenuControl : MonoBehaviour {
	public Animator animasi;
	public int param;
	public sistem dataS;
	int paramHash;
	public GameObject panelInfo;
	public Text teksInfo;
	public Text teksInfo1;
	public Text teksInfo2;


	//keperluan shop

	public int[] harga;//sejumlah 5, maerupakan score sebagai mata uang
	// Use this for initialization
	void Start () {
		paramHash = Animator.StringToHash("parameter");
	}
	
	// Update is called once per frame
	void Update () {
		teksInfo1.text = "my Score "+dataS.bestScore.ToString();
		teksInfo2.text = "my Score "+dataS.bestScore.ToString();

	}

	/**
	 * kontrol menu berdasar hash 
	 */
	public void menuType(int param){
		animasi.SetInteger(paramHash,param);
	}
	/**
	 * untuk keluar game 
	 */
	public void exitGame(){
		Application.Quit();
	}
	/**
	 * pilih pesawat 
	 */
	public void pickShip(int index){
		int score;
		score = dataS.bestScore;
		if(score > harga[index]){
			panelInfo.SetActive(true);
			teksInfo.text = "Terpilih";
			teksInfo.enabled = true;
			dataS.tipeJet = index;
			dataS.save();
		}else{
			panelInfo.SetActive(true);
			teksInfo.enabled = true;
			teksInfo.text = "Score kurang";
		}
	}

	/**
	 * pilih level 
	 */
	public void pickLevel(int index){
		int score;
		score = dataS.bestScore;
		if(score > harga[index]){
			panelInfo.SetActive(true);
			teksInfo.enabled = true;
			teksInfo.text = "Terpilih";
			SceneManager.LoadScene(index);
		}else{
			panelInfo.SetActive(true);
			teksInfo.enabled = true;
			teksInfo.text = "Score kurang";
		}
	}


	public void dismiss(){
		panelInfo.SetActive(false);

		teksInfo.enabled = false;
	}
}