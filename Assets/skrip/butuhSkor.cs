using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butuhSkor : MonoBehaviour {
	skripMainMenuControl butuhskor;
	public Text[] teks;
	// Use this for initialization
	void Start () {
		butuhskor = GetComponent<skripMainMenuControl>();
	}
	
	// Update is called once per frame
	void Update () {
		teks[0].text = butuhskor.harga[0].ToString();
		teks[1].text = butuhskor.harga[1].ToString();
		teks[2].text = butuhskor.harga[2].ToString();
		teks[3].text = butuhskor.harga[3].ToString();
		teks[4].text = butuhskor.harga[4].ToString();
		teks[5].text = butuhskor.harga[0].ToString();
		teks[6].text = butuhskor.harga[1].ToString();
		teks[7].text = butuhskor.harga[2].ToString();
		teks[8].text = butuhskor.harga[3].ToString();
		teks[9].text = butuhskor.harga[4].ToString();

	}
}
