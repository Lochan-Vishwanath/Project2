//	Name			Chau Tran
//	Last Modified	Apr 24th,2016

using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class DrawCheckPoint : MonoBehaviour {

public GameObject[] checkpoint;

	public static bool exitedplaymode=false;
	void Update()
	{
		 #if UNITY_EDITOR 
     	if (!Application.isPlaying) {
			 Debug.Log("AM BATMAN 2");
			  if ( CheckpointsSingleton.arrayofObjs.Length > 1) {
				Debug.Log("AM BATMAN 2");
				for (int i = 0; i <  CheckpointsSingleton.arrayofObjs.Length - 1; i++) {
					Debug.DrawLine ( CheckpointsSingleton.arrayofObjs [i].transform.position,  CheckpointsSingleton.arrayofObjs [i + 1].transform.position, Color.green);
					}
				}
		} 
		 //or whatever script needs to be run when in edition mode.
		 #endif


		/*//if(exitedplaymode)
		checkpoint = GameObject.FindGameObjectsWithTag ("Checkpoint");
		if (checkpoint.Length > 1) {
			Debug.Log("AM BATMAN 2");
			for (int i = 0; i < checkpoint.Length - 1; i++) {

				Debug.DrawLine (checkpoint [i].transform.position, checkpoint [i + 1].transform.position, Color.green);
			}
		}*/

	}
}

