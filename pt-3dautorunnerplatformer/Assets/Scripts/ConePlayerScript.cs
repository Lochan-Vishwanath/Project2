using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConePlayerScript : MonoBehaviour {

	public Transform pos1,pos2;
	public Material mat1,mat2;

	float pos1y,pos2y;
	bool material_changed=false;
	Renderer Myrenderer;
	Rigidbody myrb;

	public Vector3 velocity;

	void Start(){
		Myrenderer=GetComponent<Renderer>();
		pos1y=pos1.position.y;
		pos2y=pos2.position.y;
		myrb=GetComponent<Rigidbody>();
		myrb.velocity=velocity;
	}
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)||InputController.Long_yesB){
			if(transform.position.y==pos1y)
				transform.position=new Vector3(transform.position.x,pos2y,transform.position.z);
			else
				transform.position=new Vector3(transform.position.x,pos1y,transform.position.z);
		}
		if(Input.GetKeyDown(KeyCode.S)||InputController.Long_yesA){
			if(!material_changed){
				Myrenderer.material=mat2;
				material_changed=!material_changed;
			}
			else{
				Myrenderer.material=mat1;
				material_changed=!material_changed;
			}
		}
	}
}
