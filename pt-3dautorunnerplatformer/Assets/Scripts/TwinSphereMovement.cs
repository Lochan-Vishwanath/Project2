using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinSphereMovement : MonoBehaviour {

	[SerializeField]
	float speed;

	public static bool flipgravity=false,superbool=false;

	[SerializeField]
	Collider Upcollider;
	[SerializeField]
	Collider Bottomcollider;

	void Update () {
		transform.Translate(speed*Vector3.right);
		/*if(Input.GetKeyDown(KeyCode.A)||InputController.Long_yesB){
			Upcollider.gameObject.SetActive(superbool);
			Bottomcollider.gameObject.SetActive(superbool);
			flipgravity=!flipgravity;
		}
		if(superbool)
		{
			Upcollider.gameObject.SetActive(superbool);
			Bottomcollider.gameObject.SetActive(superbool);
			superbool=false;
		}
		*/
	}
}
