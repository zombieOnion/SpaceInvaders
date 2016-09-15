using UnityEngine;
using System.Collections;

//public bulletSpeed = new int;

public class BulletScript : MonoBehaviour {

	private float birthTime = Time.time;
	public float bulletSpeed = 20f;

	// Use this for initialization
	void Start () {
		//bullet kills itself after 3 seconds of existing
		Destroy(gameObject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);

	}
	void OnCollisionEnter() {
        //Bullet collides with anything, print it
		Debug.Log("Bullet collides with something. Destroys self.");
		//destroys itself
		Destroy(gameObject, 0.001f);
    }
}