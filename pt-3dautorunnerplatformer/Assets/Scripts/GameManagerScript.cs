using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

	public GameObject DifferentPlayerList;
	CameraFollow cobj;

	public float TRANSFER_JUTSU;
	bool RotateCamera=false;

	void Start(){
		cobj=Camera.main.gameObject.GetComponent<CameraFollow>();
	}
	void OnTriggerEnter(Collider coll){
		if(coll.transform.tag=="Player"){
			//Debug.Log("Here");
			GameObject Aaa=Instantiate(DifferentPlayerList,coll.transform.position,Quaternion.identity);
			Destroy(coll.gameObject);
			cobj.Playerobj=Aaa.transform;
			RotateCamera=true;
		}
	}
	void Update(){
		if(RotateCamera){
			Camera.main.transform.rotation=Quaternion.Euler(Mathf.LerpAngle(Camera.main.transform.rotation.eulerAngles.x,0,TRANSFER_JUTSU),Mathf.LerpAngle(Camera.main.transform.rotation.eulerAngles.y,0,TRANSFER_JUTSU),Mathf.LerpAngle(Camera.main.transform.rotation.eulerAngles.z,0,TRANSFER_JUTSU));
			//Debug.Log(Camera.main.transform.rotation.eulerAngles);
			if(Camera.main.transform.rotation.eulerAngles.y==0){
				Debug.Log("inside update's if");
				RotateCamera=false;
			}
		}
	}

}
