using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float Speed,jumpforce;
	Rigidbody myrb; 
	Vector3 fowardvelocity,defaultgravity;
	Animator myanimator;
	bool GravityisFlipped,BottomColiding,TopColliding;

	void Start(){
		Physics.gravity=4f*Physics.gravity;
		defaultgravity=Physics.gravity;
		GravityisFlipped=false;
		BottomColiding=TopColliding=true;
		myrb=GetComponent<Rigidbody>();
		myanimator=gameObject.GetComponent<Animator>();
		//Animation1=GetComponent<Animation>();
		//Animation1["RotateGravity_jumper"].speed=1.5f;
		
		
		
	}
	void Update(){
		
	//transform.Translate(new Vector3(Speed*Time.smoothDeltaTime,0f,0f));
	//	myrb.AddForce(Vector3.right*Speed,ForceMode.VelocityChange);
	//	myrb.velocity=Vector3.right*Speed;	
		//if(myrb.velocity.y<0){
		//	Debug.Log(myrb.velocity);
		//}
		//transform.Translate(Vector3.right*Time.deltaTime*Speed);
		//myrb.AddRelativeForce(Vector3.right*0.1f,ForceMode.Acceleration);
		



		/* 
		if(myrb.velocity.y<0 && !GravityisFlipped){
				Physics.gravity=new Vector3(Physics.gravity.x,1.15f*Physics.gravity.y,Physics.gravity.z);
			}
		if(myrb.velocity.y>0 && GravityisFlipped){
			Physics.gravity=new Vector3(Physics.gravity.x,1.15f*Physics.gravity.y,Physics.gravity.z);
		}
		*/





		if(InputController.YesA||Input.GetKey(KeyCode.A)){
			jump();
		}
		if(InputController.Long_yesB||Input.GetKeyDown(KeyCode.S)){
			Flipgravity();
		}
	}
	void FixedUpdate(){
		myrb.velocity=new Vector3(Speed,myrb.velocity.y,myrb.velocity.z);
	}
	public void jump(){
		myanimator.SetBool("jumping",true);
	
		//Animation1.Play();
		if(GravityisFlipped){
			if(TopColliding){
				//Physics.gravity=-1*defaultgravity;
				myrb.AddForce(Vector3.down*jumpforce,ForceMode.VelocityChange);
				TopColliding=false;
			}
			//TopColliding=false;
		}
		else
		if(!GravityisFlipped){
			
			if(BottomColiding){
				//Physics.gravity=defaultgravity;
				myrb.AddForce(Vector3.up*jumpforce,ForceMode.VelocityChange);
				BottomColiding=false;
			}
			//BottomColiding=false;
		}
	}
	public void Flipgravity(){
		Debug.Log("flipgravity called");
		Physics.gravity=-1*Physics.gravity;
		GravityisFlipped=!GravityisFlipped;
		InputController.Long_yesB=false;
	}

	void OnCollisionEnter(Collision cobj){
		if(cobj.transform.tag=="BottomPlatform"){
 			myanimator.SetBool("jumping",false);
			BottomColiding=true;
		}
		if(cobj.transform.tag=="TopPlatform"){
			myanimator.SetBool("jumping",false);
			TopColliding=true;
		}
	}
	//void OnCollisionExit(Collision cobj){
	//	if(cobj.transform.tag=="BottomPlatform"){
	//		BottomColiding=false;
	//	}
	//	if(cobj.transform.tag=="TopPlatform"){
	//		TopColliding=false;
	//	}
	// }
	

}
