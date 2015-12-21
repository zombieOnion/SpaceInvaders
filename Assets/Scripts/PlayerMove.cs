using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	//private Transform tempPosition;
	public float speed = 10;
	public float translation;
	private Quaternion rotation;
	// Use this for initialization
	void Start () {
		//tempPosition.translate = transform.translate;
		translation = Input.GetAxis("Vertical") * speed;
	}


	
	// Update is called once per frame
	void Update () {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //translation *= Time.deltaTime;
        transform.Translate(0, translation, 0);
        if(transform.position.y >=11){
        	Debug.Log("TOO HIGH");
        	transform.position = new Vector3(-14, -10, 0);
        }
        if(transform.position.y <=-11){
        	Debug.Log("TOO LOW");
        	transform.position = new Vector3(-14, 10, 0);
        }
	}
}
