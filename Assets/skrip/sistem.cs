using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[ExecuteInEditMode]
public class sistem : MonoBehaviour {
	public string lokasi;
	public int lives;
	public int level;
	public int skor;
	public int tipeJet;
	public int bestScore;

	//public bool 
	public bool isResetting;
	public bool isSaving;
	public bool isLoading;
	// Use this for initialization
	void Start () {
		load();
	}
	
	// Update is called once per frame
	void Update () {
		systemDiagnose();
	}

	void systemDiagnose(){
		if(isResetting){
			reset();
			isResetting=false;
		}
		if(isSaving){
			save();
			isSaving=false;
		}
		if(isLoading){
			load();
			isLoading = false;
		}
	}

	//system
	public void save()
	{
		BinaryFormatter bin = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath+lokasi);
		//call the data class and parse to local value
		runData dataS = new runData();
		//save here
		dataS.lives = lives;
		dataS.skor = skor;
		dataS.level = level;
		dataS.tipeJet = tipeJet;
		dataS.bestScore = bestScore;
		//convert to binary. filename,data
		bin.Serialize(file,dataS);
		file.Close();
		Debug.Log("save success");
	}

	public void load()
	{
		//check if file exists
		if(File.Exists(Application.persistentDataPath+lokasi)){
			BinaryFormatter bin = new BinaryFormatter();
			//access
			FileStream file = File.OpenRead(Application.persistentDataPath+lokasi);
			runData dataS = (runData)bin.Deserialize(file);//convert me this
			file.Close();
			//parsing parameter
			lives = dataS.lives;
			level = dataS.level;
			skor = dataS.skor;
			tipeJet = dataS.tipeJet;
			bestScore = dataS.bestScore;
			//EndOfStreamException of parameter
		}
		Debug.Log("load success");
	}



	//system
	public void reset()
	{
		BinaryFormatter bin = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath+lokasi);
		//call the data class and parse to local value
		runData dataS = new runData();
		//save here
		dataS.lives = 3;
		dataS.level = 0;
		dataS.skor = 0;
		dataS.tipeJet = 0;
		dataS.bestScore = 0;
		//convert to binary. filename,data
		bin.Serialize(file,dataS);
		file.Close();
		Debug.Log("Reset success");
	}
	//system
}
	
//data to be saved
[Serializable]
class runData{
	public int lives;
	public int skor;
	public int level;
	public int tipeJet;
	public int bestScore;
}
