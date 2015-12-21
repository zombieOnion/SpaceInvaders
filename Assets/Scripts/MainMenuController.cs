using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	// Use this for initialization
	/*void Start () {
	
	}
	
	// Update is called once per frame
	/*void Update () {
	
	}*/
	public void LoadLevel(string level){
		string toLoad = level;
		Application.LoadLevel (toLoad);
	}
	public void QuitGame(){
		Debug.Log("quit/exit game");
		Application.Quit();
	}
	
}