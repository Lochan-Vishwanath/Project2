using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_0 : MonoBehaviour {

	// Use this for initialization
	public Transform downgroundcheck,upgroundcheck;
	Rigidbody2D myRb;
	Vector3 offset,newpos;
	public float speed;
	//public float distancea;
	public int jumpheight;
	bool onground=false;
	public LayerMask groundlayer;
	int i=1;

	//gravity Flipping
	bool gravityfliped=false;
	bool pass=false;
	//bool flag1=false,flag2=true;

	float lowy=6.0f;
	Camera cameramain;
	void Start () {
		cameramain = Camera.main;
		myRb = GetComponent<Rigidbody2D> ();
		offset = cameramain.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//camera code
		newpos = transform.position + offset;
		newpos.y = lowy;
		cameramain.transform.position = Vector3.Lerp (cameramain.transform.position, newpos, 100f);

		//moving box 
		myRb.velocity = new Vector2 (speed, myRb.velocity.y);

		//gravityflipping
		if (Input.GetKeyDown (KeyCode.A)) {
			gravityfliped = !gravityfliped;
			Debug.Log (gravityfliped);
			Physics2D.gravity = -1 * Physics2D.gravity;
			i = 1;
		}

	
		//checking jump when gravity not flipped
		if (gravityfliped == false) {

			i += 1;
			if (Physics2D.OverlapCircle (downgroundcheck.position, 0.8f, groundlayer)) {
				Quaternion rot = transform.rotation;
				rot.z = Mathf.Round (rot.z / 90) * 90;
				transform.rotation = rot;
				onground = true;

			} else
				onground = false;

			if (Input.GetKey(KeyCode.S) && onground)
				myRb.velocity = Vector2.up * jumpheight;
			else if ((onground == false) && (i % 2 == 0)) {//wheni%2==0the rotate operation will work that is every 2 frame the square will rotate.
				transform.Rotate (Vector3.back * 18f);
			}
		} else {
			

			if(pass)
			i += 1;
			if (Physics2D.OverlapCircle (upgroundcheck.position, 0.8f, groundlayer)) {
				Quaternion rot = transform.rotation;
				rot.z = Mathf.Round (rot.z / 90) * 90;
				transform.rotation = rot;
				onground = true;

				pass = true;

			} else
				onground = false;

			if (Input.GetKey (KeyCode.S) && onground)
				myRb.velocity = Vector2.down * jumpheight;
			else if ((onground == false) && (i % 2 == 0)) {//wheni%2==0the rotate operation will work that is every 2 frame the square will rotate.
				transform.Rotate (Vector3.forward * 18f);
			}
		}


			/*if (flag2 == false) {
				myRb.velocity = Vector2.down * 50;
				flag2 = true;
					}

			if (Physics2D.Raycast ((Vector2)racastpos.position, Vector2.down, distancea)&&flag2) {
				//Quaternion rot = transform.rotation;
				//rot.z = Mathf.Round (rot.z / 90) * 90;
				//transform.rotation = rot;
				if (Input.GetKey (KeyCode.S)) {
					//myRb.velocity = Vector2.zero;
					myRb.velocity = Vector2.up * jumpheight;//+ Vector2.right * speed;

					}
				} 
			//else   //fliping 360
			//	myRb.transform.Rotate (Vector3.back * 9f);*/
		
			
		
		//else 
		//{

			/*if (flag1 == false) {
				myRb.velocity = Vector2.up * 50;
				flag1 = true;
			}
			Physics2D.gravity = -1 * Physics2D.gravity;
			if ((Physics2D.Raycast ((Vector2)(racastpos.position+transform.position*2), Vector2.up, distancea))&&flag1) {
				Quaternion rot = transform.rotation;
				rot.z = Mathf.Round (rot.z / 90) * 90;
				transform.rotation = rot;
				if (Input.GetKey (KeyCode.S)) {
					//myRb.velocity = Vector2.zero;
					myRb.velocity = Vector2.down * jumpheight;//+ Vector2.right * speed;

				}
			} else
				if(flag1)//fliping 360
					myRb.transform.Rotate (Vector3.back * 9f);*/


		
			
	}
}

