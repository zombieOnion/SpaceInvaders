using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScore : MonoBehaviour {
	//create memory place for invader object
	public GameObject[] invader;
	public GameObject[] inv;
	public GameObject enemyKillzone;
	public GameObject buttonRestart;
	public GameObject buttonQuit;
	public GameObject textYouLose;
	public GameObject textYouWin;
	public int Score;
	public int enemiesLeft;
	public Text scoreText;
	public AudioSource audio;
	// Use this for initialization
	void Start () {
		invader = GameObject.FindGameObjectsWithTag("invader");
		if (inv != null){
			Debug.Log("invaders exist");
		scoreText.text = "Kills: ";
		}
		audio = GetComponent<AudioSource>();
		enemiesLeft = invader.Length;
		textYouLose.SetActive(false);
		textYouWin.SetActive(false);
		buttonRestart.SetActive(false);
		buttonQuit.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ScoreKeep(int newScore){
		Score = Score+newScore;
		scoreText.text = "Kills:" + Score.ToString();
		invader = GameObject.FindGameObjectsWithTag("invader");
		if(invader.Length == 0){
			//Display the 2 buttons
			Debug.Log("No more enemeies left, displaying restart/quit buttons");
			enemyKillzone.SendMessage("PlayAudio");
			buttonRestart.SetActive(true);
			buttonQuit.SetActive(true);
			textYouWin.SetActive(true);
		}

	}

	public void PlayAudioExplosion(){
		audio.Play();
	}

	public void RestartLevel(){
		Debug.Log("Restart Pressed");
		 Application.LoadLevel(Application.loadedLevel);
	}
	public void QuitGame(){
		Debug.Log("QUIT GAME PRESSED");
		Application.LoadLevel("level_mainMenu");
	}
	void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        Debug.Log("PlayerShip collides with something");
        ScoreKeep(-10);
        buttonRestart.SetActive(true);
		buttonQuit.SetActive(true);
		textYouLose.SetActive(true);
    }
}