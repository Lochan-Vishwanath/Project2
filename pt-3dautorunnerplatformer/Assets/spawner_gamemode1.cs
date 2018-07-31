using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_gamemode1 : MonoBehaviour {

	// Use this for initialization
	public GameObject spawnpoint,objparent,objchild1,objchild2;
	//Rigidbody2D myrb;
	bool created=false;
	void Start (){
		//myrb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		//myrb.collisionDetectionMo
	}


/*	void OnTriggerEnter2D(Collider2D other){
	if(other.tag=="character"){
			Destroy (other.gameObject);
			Debug.Log ("gamemode 2 chsanged");
			if (created == false) {
				created = true;
				GameObject a1, b1;
				Transform a,b,c;
				a1= Instantiate (objparent, spawnpoint.transform.position + Vector3.up, Quaternion.identity);
				/*a = a1.transform;
				b1=Instantiate (objchild1);
				b = b1.transform;
				b.parent = a;
			}

		}
	}
*/
}