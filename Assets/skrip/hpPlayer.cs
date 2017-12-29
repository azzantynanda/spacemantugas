using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpPlayer : MonoBehaviour {
	public float hp;
	public float maxHP;
	public Slider uiHP;
	bool hasSlider;
	// Use this for initialization
	void Start () {
		uiHP.maxValue = maxHP;
		hp = maxHP;
	}
	
	// Update is called once per frame
	void Update () {
		uiHP.value = hp;
		
	}

	public void demagedByContact(float amount){
		Debug.Log("decreased");
		hp -= amount;
	}

}
