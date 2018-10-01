using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mode3_controller : MonoBehaviour {

	// camera varibles
	Vector3 offset,newpos;
	public Transform a,b,c,d;
	Vector3 aa,bb,cc,dd;
	Camera cameramain;
	public int speed;
	float lowy=6.00f;
	//float positiony;
	bool updowna=true,mode=true;

	void Start () {
		//camera
		aa=a.position;
		bb = b.position;
		cc = c.position;
		dd = d.position;
		//positiony = transform.position.y;
		cameramain = Camera.main;
		offset = cameramain.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//camera code
		newpos = transform.position + offset;
		newpos.y = lowy;
		cameramain.transform.position = Vector3.Lerp (cameramain.transform.position, newpos, 1f);

		transform.Translate(speed*Time.smoothDeltaTime,0f,0f);
		//mode 3 a
		if (Input.GetKeyDown (KeyCode.A)) {
			if (mode) {
				if (transform.position.y == aa.y)
					transform.position = new Vector3 (transform.position.x, dd.y, transform.position.z);
				if (transform.position.y == bb.y)
					transform.position = new Vector3 (transform.position.x, cc.y, transform.position.z);
			} else {
				if (transform.position.y == dd.y)
					transform.position = new Vector3 (transform.position.x, aa.y, transform.position.z);
				if (transform.position.y == cc.y)
					transform.position = new Vector3 (transform.position.x, bb.y, transform.position.z);
			}
			mode = !mode;
		}
		if (Input.GetKeyDown (KeyCode.S)&&mode) {
			if (updowna) {
				transform.position = new Vector3(transform.position.x,bb.y,transform.position.z);
				updowna = !updowna;
			} else {
				transform.position = new Vector3(transform.position.x,aa.y,transform.position.z);
				updowna = !updowna;
			}
		}
		if (Input.GetKeyDown (KeyCode.S) && !mode) {
			if (updowna) {
				transform.position = new Vector3(transform.position.x,cc.y,transform.position.z);
				updowna = !updowna;
			} else {
				transform.position = new Vector3(transform.position.x,dd.y,transform.position.z);
				updowna = !updowna;
			}
		}


	}
}
