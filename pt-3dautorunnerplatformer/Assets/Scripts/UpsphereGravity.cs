using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpsphereGravity : MonoBehaviour {

	Rigidbody rb;
	public Vector3 objgravity;

	[SerializeField]
	Collider Upcollider;

	bool ontimeentry=false;
	void Start () {
		rb=GetComponent<Rigidbody>();
		objgravity=Physics.gravity*rb.mass*rb.mass*5;
	}
	
	void FixedUpdate () {
		rb.useGravity=false;
		if(!TwinSphereMovement.flipgravity)
			rb.AddForce(objgravity);
		else
			rb.AddForce(-objgravity);

		if(Input.GetKey(KeyCode.S) && !TwinSphereMovement.flipgravity){
			rb.AddForce(-objgravity*1000);
		}
		if(Input.GetKey(KeyCode.S) && TwinSphereMovement.flipgravity){
			rb.AddForce(objgravity*1000);
		}
	}

	void Update(){
		if((Input.GetKeyDown(KeyCode.A)||InputController.Long_yesB) && !ontimeentry ){
			//TwinSphereMovement.flipgravity=!TwinSphereMovement.flipgravity;
			Upcollider.gameObject.SetActive(false);
			ontimeentry=true;
		}
		if(!InputController.Long_yesB){
			ontimeentry=false;
		}
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag=="TopPlatform" || col.gameObject.tag=="SphereMiddleCollider"){
			Upcollider.gameObject.SetActive(true);
		}
	}
}
