using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	Vector3 bulletPosition = new Vector3(1.5f,0,0);

	Object varBullet;
	void Start () {
		varBullet = Resources.Load("pref_Bullet");
		//Vector3 bulletPosition = new Vector3(0,2,0);
		Debug.Log("Bullet prefab loaded");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")){
			Debug.Log("PEW!");
			//Instantiate(varBullet);

			Instantiate(varBullet, transform.position + bulletPosition, transform.rotation);
		}

	}
}