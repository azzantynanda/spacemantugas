using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiskor : MonoBehaviour {
	public Text teksSkor;
	public Text teksBestSkor;
	public sistem dataSistem;
	public Done_GameController dataGame;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	/**
	 *Membandingkan score dan best score 
	 */
	public void check_skor(){
		if(dataGame.gameOver){
			teksSkor.text = "Score "+dataGame.score.ToString();
			teksBestSkor.text = "Best Score "+dataSistem.bestScore.ToString();
			//bandingkan score sistem dengan sekarang jika lebih besar sekarang simpan yang sekarang
			int curskor=0;
			int newskor=0;
			newskor = dataGame.score;
			curskor = dataSistem.bestScore;
			if(newskor>curskor){
				dataSistem.bestScore = newskor;
				dataSistem.save();
			}
		}		
	}
}
