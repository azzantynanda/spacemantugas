using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Done_GameController : MonoBehaviour
{
	public GameObject[] hazards;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	public Text scoreText;
	public Text restartText;
	public Text gameOverText;
	public GameObject panelGameOver; 
	public uiskor skorUI;
	
	[HideInInspector]public bool gameOver;
	private bool restart;
	[HideInInspector]public int score;
	
	void Start ()
	{
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		score = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}
	
	void Update ()
	{
		GameOverChk();
	}

	void GameOverChk(){
		if (gameOver)
		{
			//restartText.text = "Press 'R' for Restart";
			//restart = true;
			panelGameOver.SetActive(true);
			if(skorUI !=null){
				skorUI.check_skor();
			}
		}
	}

	public void resetScene(){
	//	if (restart)
	//	{
	//		if (Input.GetKeyDown (KeyCode.R))
	//		{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	//		}
	//	}
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			//yield return new WaitForSeconds (waveWait);
			if(gameOver){
				break;
			}
		}
	}
	
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}
	
	public void GameOver ()
	{
		gameOverText.text = "Game Over!";
		gameOver = true;
	}

	public void bukaScene(int index){
		SceneManager.LoadScene(index);
	}
}