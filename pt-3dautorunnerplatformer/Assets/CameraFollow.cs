using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Vector3 offset;
	//public static CameraFollow cobj;
	Vector3 camerapos3D;
	Quaternion camerarot3D; 
	public Transform Playerobj;
	void start(){
		camerapos3D=offset;
		//camerapos3D=transform.position;
		camerarot3D=transform.rotation;
	}
	void LateUpdate(){
		Vector3 finalposition;
		finalposition=Playerobj.position+offset;
		finalposition=new Vector3(finalposition.x,transform.position.y,finalposition.z);
		transform.position=Vector3.Lerp(transform.position,finalposition,0.125f);
	}


}
