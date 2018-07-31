using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptTwoGames : MonoBehaviour {

	public float Speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Time.smoothDeltaTime*Speed*Vector3.right);
	}
}
