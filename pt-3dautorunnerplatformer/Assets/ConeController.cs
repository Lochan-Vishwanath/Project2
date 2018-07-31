using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeController : MonoBehaviour {

	[SerializeField]
	Transform up,down;

	bool downbool=false;
	
	void Start () {
		transform.position=up.position;
	}
	void Update () {
		if(InputController.YesA){
			if(downbool){
				transform.position=up.position;
				//downbool=false;
			}
			if(!downbool){
				transform.position=down.position;
				//downbool=true;
			}
			downbool=!downbool;
		}
	}
}
