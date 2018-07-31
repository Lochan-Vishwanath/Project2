using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_1_a : MonoBehaviour {

	// Use this for initialization
	//Rigidbody2D myrb;
	//public GameObject a,b;
	//public Collider2D up,down;
	//CharacterController controller;
	public float speed;
	float lowy=6.00f;
	float positiony;
	//Vector2 originalgravity;
	//bool state=true;


	//Vector2 transformoriginalposition;
	//jumping
	//public float jumpheight;

	Vector3 offset,newpos;
	Camera cameramain;


	void Start () {
		//controller = GetComponent<CharacterController>();
		positiony = transform.position.y;
		cameramain = Camera.main;
		//myrb = GetComponent<Rigidbody2D> ();
		//xa = GetComponent<Rigidbody2D> ();

		//originalgravity = Physics2D.gravity;
		offset = cameramain.transform.position - transform.position;
	}

	// Update is called once per frame
	void Update () {
		
		//camera code
		newpos = transform.position + offset;
		newpos.y = lowy;
		cameramain.transform.position = Vector3.Lerp (cameramain.transform.position, newpos, 1f);


		//constant movement
		//myrb.velocity=new Vector2(speed,myrb.velocity.y);
		transform.Translate(speed*Time.smoothDeltaTime,0f,0f);

		/*if (Input.GetKey(KeyCode.S)) {
			if (state) {
				a.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, jumpheight);
				b.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, -jumpheight);
			}
			if (!state) {
				a.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, -jumpheight);
				b.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, jumpheight);
			}
			//if (a.transform.position.y <= jumpheight)
		//	a.transform.Translate(new Vector3(0f,jumpheight));
				//flag = !flag;
			//if(flag)
				//a.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, jumpheight);
			//a.GetComponent<CharacterController>().SimpleMove(new Vector3(0f,jumpheight));
			//a.transform.Translate(0f,jumpheight*Time.,0f);
		//	a.transform.position=Vector3.Lerp(a.transform.position,a.transform.position+new Vector3(0f,jumpheight,0f)*Time.deltaTime,0.5f);
		//	a.transform.position = Vector3.Lerp(a.transform.position,a.transform.position+new Vector3 (0f, -1 / 2 * Physics2D.gravity.y * Time.deltaTime * Time.deltaTime, 0f),0.5f);
			//b.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, -jumpheight);
			//a.transform.position = Vector3.Lerp (a.transform.position, a.transform.position + new Vector3 (0f, 5f), 0.05f);
		}
		//if (flag)
		//if (a.transform.position.y <= jumpheight) {
			//a.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, jumpheight);
		//	a.transform.Translate(new Vector3(0f,jumpheight*Time.deltaTime));
		//	}


		//character movement
			
	//myrb.velocity = new Vector2 (speed, myrb.velocity.y);

		//if (Input.GetKeyDown (KeyCode.S)) {
		/*	transformoriginalposition = transform.position;
			transform.position = Vector2.Lerp (transform.position, new Vector2 (transform.position.x, transform.position.y + 0.07f), 4f);
			flag = true;
			i = 0;
		}
		if (flag == true && i>50) {
			transform.position = Vector2.Lerp (transform.position, transformoriginalposition, 4f);
			flag = false;
		}*/
		/*if (Input.GetKeyDown (KeyCode.A)) {
			state = !state;
			if (state) {
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
			}


		*/
	}
/*void onCollisionEnter2D(Collider2D coll){
	if(coll.gameObject.tag=="charactera")
		Debug.Log ("booi");
}*/
}
