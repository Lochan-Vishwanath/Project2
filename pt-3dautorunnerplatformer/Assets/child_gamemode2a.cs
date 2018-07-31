using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child_gamemode2a : MonoBehaviour {

	// Use this for initialization
	//present_in_area piobj;
	public GameObject a;//,b;
	Rigidbody2D thisrb;
	public Collider2D up,down;
	//CharacterController controller;
	//public float speed;
	//float lowy=6.00f;
	//float positiony;
	Vector2 originalgravity;
	bool state=true;
	bool flag=false;


	//Vector2 transformoriginalposition;
	//jumping
	public float jumpheight;

	//Vector3 offset,newpos;
	//Camera cameramain;
	//Vector2 gravityvalue;
	void Start () {
		originalgravity = Physics2D.gravity;
		thisrb = GetComponent<Rigidbody2D> ();


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.S)) {
			if (state) {
				a.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, jumpheight);
				//b.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, -jumpheight);
				thisrb.velocity=new Vector2(0f,-jumpheight);
			}
			if (!state) {
				a.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, -jumpheight);
				//b.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, jumpheight);
				thisrb.velocity=new Vector2(0f,jumpheight);
			}
		}





		if (Input.GetKeyDown (KeyCode.A)) {
			state = !state;
			flag = true;
			/*if (state) {
				Physics2D.gravity = originalgravity*500;
				Physics2D.gravity = originalgravity;
				up.enabled = true;
				down.enabled = true;
			}
			if (!state) {
				up.enabled = false;
				down.enabled = false;
				Physics2D.gravity = -1 * originalgravity*500;
				Physics2D.gravity = -1 * originalgravity;

			}
			*/

		}
		if (present_in_area.inarea && !flag) {
			up.enabled = true;
			down.enabled = true;
			Physics2D.gravity = originalgravity;
			Debug.Log ("am inside area");
		}
		if (present_in_area.inarea && flag) {
			Physics2D.gravity = -1 * originalgravity * 5000;
			up.enabled = false;
			down.enabled = false;

			flag = false;
			Debug.Log ("am going outside area");
		}
		if (!present_in_area.inarea && !flag) {
			up.enabled = true;
			down.enabled = true;
			Physics2D.gravity = -1 * originalgravity;
			Debug.Log ("am outside area");
		}
		if (!present_in_area.inarea && flag) {
			Physics2D.gravity = originalgravity * 5000;
			up.enabled = false;
			down.enabled = false;

			flag = false;
			Debug.Log ("am going inside area");
		}
		/*if(state && flag)
			Physics2D.gravity = originalgravity*500;
		if(!state && flag)
			Physics2D.gravity = -1*originalgravity*500;
		if(state && !flag)
			Physics2D.gravity = originalgravity;
		if(!state && !flag)
			Physics2D.gravity = -1*originalgravity;
		*/
	}
	/*void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "charactera") {
			//Physics2D.gravity = Vector2.zero;
			Debug.Log("character enter");
			up.enabled = true;
			down.enabled = true;
			flag = false;
		}
		if (coll.gameObject.tag == "platformer") {
			Debug.Log ("platform enter");
			up.enabled = true;
			down.enabled = true;
			flag = false;
		}
	}
	void OnCollisionExit2D(Collision2D coll){
		if (coll.gameObject.tag == "charactera") {
			//Physics2D.gravity = originalgravity;	
			Debug.Log("character exit");
			if (flag) {
				//Physics2D.gravity = -1 * originalgravity;
				up.enabled = false;
				down.enabled = false;
			}
		}
		if (coll.gameObject.tag == "platformer") {
			Debug.Log ("platformer exit");
			if (flag) {
				//Physics2D.gravity = originalgravity;
				up.enabled = false;
				down.enabled = false;
			}
		}
	}*/
}
