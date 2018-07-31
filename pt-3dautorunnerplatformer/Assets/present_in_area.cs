using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class present_in_area : MonoBehaviour {

	public static bool inarea=true;
	void Update(){
		//inarea = false;
	}
	void OnTriggerStay2D(Collider2D coll){
		if (coll.gameObject.tag == "charactera") {
			inarea = true;
			//Debug.Log ("satying in area");
		}
	}
	void OnTriggerExit2D(Collider2D coll){
		if (coll.gameObject.tag == "charactera") {
			inarea = false;
			//Debug.Log ("out of in area");
		}
	}
}
