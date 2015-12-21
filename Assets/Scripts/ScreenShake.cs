using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator ShakeIt (int mag){
			Vector3 oldPosition = new Vector3();
			oldPosition = GetComponent<Rigidbody>().position;
			int j;
			for(int i=mag;i > 0; i--){
				j = i;
				i = i/5;
				gameObject.transform.Translate(Random.Range(-i, i), Random.Range(-i, i), 0);
				yield return new WaitForSeconds(0.1f);
				GetComponent<Rigidbody>().position = oldPosition;
				Debug.Log("SHAKE");
				i = j;
			}
			
			
	}
}
