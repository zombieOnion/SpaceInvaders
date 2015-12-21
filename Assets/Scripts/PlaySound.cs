using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	public AudioSource winsound;
	// Use this for initialization
	void Start () {
		winsound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void PlayAudio(){
		winsound.Play();
	}
}
