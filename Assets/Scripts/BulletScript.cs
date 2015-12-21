using UnityEngine;
using System.Collections;

//public bulletSpeed = new int;

public class BulletScript : MonoBehaviour {

	public float birthTime = Time.time;

	// Use this for initialization
	void Start () {
		//bla bla
		//birthTime = Time.time;
		Destroy(gameObject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * 20 * Time.deltaTime);

		//On collision with anything else
		//wait 0,5 seconds
		//Destroy self
		//if(birthTime+10 > Time.time)
		//	{Destroy(gameObject);}

	}
	void OnCollisionEnter() {
        //Bullet collides with anything, print it
		Debug.Log("Bullet collides with something. Destroys self.");
		Destroy(gameObject, 0.001f);
    }
}