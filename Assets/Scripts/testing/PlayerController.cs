using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 10;
	public float translation;
	public float shotPower;
	private Quaternion rotation;
	private float startTime;
	private float endTime;
	// Use this for initialization
	void Start () {
		translation = Input.GetAxis("Horizontal") * speed;
	}
	
	// Update is called once per frame
	void Update () {
		translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		transform.Translate(translation, 0f, 0f);
		if(transform.position.x >=11f){
        	Debug.Log("TOO HIGH");
        	transform.position = new Vector3(-10f, -3.5f, 0f);
        }
        if(transform.position.x <=-11f){
        	Debug.Log("TOO LOW");
        	transform.position = new Vector3(10f, -3.5f, 0f);
        }
        //if space button pushed
        if(Input.GetButtonDown("Jump")){
        	startTime = Time.time;
        	Debug.Log(startTime);
        }
        //get startTime
        //start playing sound

        //when space button released
        if(Input.GetButtonUp("Jump")){
        	endTime = Time.time;
        	shotPower = endTime - startTime;
        	Debug.Log("StartTime: " + startTime + ", EndTime: " + endTime + ", deltaTime: " + shotPower);
        }
        //print endTime-startTime=shotPower
        //cap shot power at a reasonable variable
	}
}
