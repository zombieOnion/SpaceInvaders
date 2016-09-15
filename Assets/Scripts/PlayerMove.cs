using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	//private Transform tempPosition;
	public float speed = 10;
	public float translation;
	private Quaternion rotation;
	private float ClickMove = 0;
	private Vector2 touchOrigin = -Vector2.one;
	public Animation ship_idle;
	public Animation ship_moveUp;
	public Animation ship_moveDown;
	public Animation ship3danim;
	// Use this for initialization
	void Start () {
		//tempPosition.translate = transform.translate;
		translation = Input.GetAxis("Vertical") * speed;
		ship3danim = GetComponentInChildren<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        //moves the ship: takes vertical axis input, multipies with delta time, adjusts player position accordingly
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, translation, 0);
        //wraparound code teleports the player ship to the other side of the screen when it goes out too far in any direction:
        if(transform.position.y >=11){
        	Debug.Log("TOO HIGH");
        	transform.position = new Vector3(-14, -10, 0);
        }
        //wraparound code teleports the player ship to the other side of the screen when it goes out too far in any direction:
        if(transform.position.y <=-11){
        	Debug.Log("TOO LOW");
        	transform.position = new Vector3(-14, 10, 0);
        }

        if (Input.GetKeyDown("down") || Input.GetKeyDown("s")){
        	//ship_moveDown.Play();
           	//blend from current playing animation to anim_moveDown
        	ship3danim.Play("anim_shipMoveDown");

           //Debug.Log("down pressed");
        }
        else if (Input.GetKeyDown("up") || Input.GetKeyDown("w")){
        	//blend from current playing animation to anim_moveUp
        	ship3danim.Play("anim_shipMoveUp");
        }
        else if(Input.GetKeyUp("down") || Input.GetKeyUp("s") || Input.GetKeyUp("up") || Input.GetKeyUp("w")){
        	ship3danim.Play("anim_shipIdle");
        }


	}
}
