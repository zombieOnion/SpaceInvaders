using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	public float Speed = 10;
	public float HitPoints = 4;
	private float MaxHitPoints;
	public Material material;
	public Renderer rend;
	public GameObject PlayerShipVar;
	public GameObject MainCameraVar;
	string collided = "none yet";
	public int score;
	public AudioSource hitSound;
	Vector4 enemyShipColor = new Vector4(1,0,0,1);
	
	void Start () {

		MaxHitPoints = HitPoints;
		Speed = Speed * -1;
		//find the player ship, set pointer to it.
		PlayerShipVar = GameObject.Find("PlayerShip");
		MainCameraVar = GameObject.Find("MainCamera");
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		hitSound = GetComponent<AudioSource>();
		rend.material.SetColor("_Color",enemyShipColor);
	}
	// Update is called once per frame
	void Update () {
        transform.Translate(Speed * Time.deltaTime, 0, 0);
	}

	//what happens when we collide with a bullet?
	void OnCollisionEnter(Collision col){
		//find out if we collided with a bullet
		
		//if we hit a bullet that is
		collided = col.gameObject.name;
		Debug.Log(collided);
		if(collided == "pref_Bullet(Clone)"){
			HitPoints--;
			hitSound.Play();
			//set color property to darker, and redder
			enemyShipColor[0] = enemyShipColor[0]-0.25f;
			//enemyShipColor[0] = showHP;
			rend.material.SetColor("_Color", enemyShipColor);

		}
		
		if(HitPoints<=0){
			//this kills the Enemy. Do screenshake.
			gameObject.tag = "lol";
			PlayerShipVar.SendMessage("ScoreKeep", 1);
			MainCameraVar.SendMessage("ShakeIt", 5);
			PlayerShipVar.SendMessage("PlayAudioExplosion");
			
			Destroy(gameObject);
		}
		
	}

}
