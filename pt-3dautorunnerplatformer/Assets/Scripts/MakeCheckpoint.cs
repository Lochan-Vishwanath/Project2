//	Name			Chau Tran
//	Last Modified	Apr 24th,2016

using UnityEngine;
using System.Collections;

public class MakeCheckpoint : MonoBehaviour {

    GameObject objToSpawn;
	public float waitTime = 0.2f;

	// Draw a line every fram. This is as smooth and fast as Unity can do

/*	void FixedUpdate()
	{
		objToSpawn = new GameObject ("Checkpoint");
		objToSpawn.tag = "Checkpoint";
		objToSpawn.transform.position = this.transform.position;
	}
	 void OnApplicationQuit(){
		 CheckpointsSingleton.arrayofObjs= GameObject.FindGameObjectsWithTag ("Checkpoint");
		 DrawCheckPoint.exitedplaymode=true;
		 //if (!Application.isPlaying)
		 for (int i = 0; i <  CheckpointsSingleton.arrayofObjs.Length - 1; i++) {
					Debug.DrawLine ( CheckpointsSingleton.arrayofObjs [i].transform.position,  CheckpointsSingleton.arrayofObjs [i + 1].transform.position, Color.green);
					}
		 if(CheckpointsSingleton.arrayofObjs.Length>5){
			 Debug.Log("AM BATMAN");
		 }
	 }

*/	 

	// Draw it after every certain amount of time
	void Start()
	{
        StartCoroutine (DrawPath(waitTime));
	}

	IEnumerator DrawPath(float timeRate)
	{
		while (true) {
			objToSpawn = new GameObject ("Checkpoint");
			objToSpawn.tag = "Checkpoint";
			objToSpawn.transform.position = transform.position;
			// wait before do this again
			yield return new WaitForSeconds (timeRate);
		}
	}


}