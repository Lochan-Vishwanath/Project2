using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCubeController : MonoBehaviour {

	Rigidbody myrb;
	public float JumpHeight=1f;

	Animator myanimator;
	bool BottomColiding;
	void Start(){
		myrb=GetComponent<Rigidbody>();
		myanimator=GetComponent<Animator>();
		Physics.gravity=new Vector3(Physics.gravity.x,Physics.gravity.y*1.5f,Physics.gravity.z);
	}
	public void jump(){
	
		myanimator.SetBool("minijumping",true);
		if(BottomColiding){
			myrb.AddForce(Vector3.up*JumpHeight,ForceMode.Acceleration);
			BottomColiding=false;
		}
	}
	void Update(){
		if(InputController.YesB||Input.GetKey(KeyCode.A)){
			jump();
		}
	}
	void OnCollisionEnter(Collision cobj){
		if(cobj.transform.tag=="BottomPlatform"){
			myanimator.SetBool("minijumping",false);
			BottomColiding=true;
		}
	}
}
