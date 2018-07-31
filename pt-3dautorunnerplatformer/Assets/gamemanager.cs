using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour {
	bool  created=false;
	public static Vector3 positionvector;
	//gamemode
	public int gamemode = 0;
	//gamemode player sprites
	public Transform[] mytransforms;
	//cameraobj position moving with player sprite
	public GameObject playerspawnpos;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		switch (gamemode) {
		case 0:
			if (created == false) {
				Instantiate (mytransforms [0], playerspawnpos.transform.position, playerspawnpos.transform.rotation);
				created = true;
				positionvector = mytransforms [0].position;
			}
			//Physics2D.gravity = Vector2.zero;
			break;
		}
	}
}
