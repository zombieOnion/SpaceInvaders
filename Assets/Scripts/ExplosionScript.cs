using UnityEngine;
using System.Collections;

public class ExplosionScript : MonoBehaviour {

	private float birthTime = Time.time;
	public float lifeTime = 0.3f;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, lifeTime);
	}
	
	// Update is called once per frame
	/*void Update () {
	
	}*/
}
