using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {
	
	public float speed = 1f;
	//public float rotationAngleX = 30f;
	//public float rotationAngleY = 0f;
	//public float rotationAngleZ = -10f;
	//public Quaternion rotateUp = Quaternion.Euler(0, 30, 0);
	//public Quaternion rotateDown = Quaternion.Euler(0, -30, 0);
	//public Quaternion rotateZero = Quaternion.Euler(0,0,0);
	//public Quaternion rotation = Quaternion.Euler(0, 30, 0);
	// Use this for initialization
	void Start () {
//		rotationAngleX = 30f;
//		rotationAngleY = 30f;
//		rotationAngleZ = 30f;
		//rotateUp = new Quaternion.Euler(rotateAngleZ, rotateAngleX, rotateAngleY);
		//Quaternion rotateDown = new Quaternion(-rotationAngleX, rotateAngleY, rotateAngleZ);
		//Quaternion rotateZero = new Quaternion(0f, 0f, 0f);
	}
	// Update is called once per frame
	void Update () {
		//transform.rotation = Quaternion.Slerp (rotateZero, rotateUp, Time.time * speed);
		transform.Rotate(1, Time.deltaTime, 0);
//		transform.Rotate(Vector3.Up * Time.deltaTime);
		if(Input.GetKey("up")){
			//rotate self to plus 30 degrees X
			//Debug.Log("Rotate 30 x");
			
		}
		else if(Input.GetKey("down")){
			//rotate self to minus 30 degrees X
			//Debug.Log("Rotate -30 x");
		}
		//transform.Rotate(Vector3.x, Time.deltaTime);
	}
}
