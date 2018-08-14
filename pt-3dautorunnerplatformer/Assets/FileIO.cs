using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileIO : MonoBehaviour {

	//path=Assets/Resources/txtfile.txt
	
	public GameObject[] checkpoint;

	void FixedUpdate(){
		checkpoint=GameObject.FindGameObjectsWithTag ("Checkpoint");

		//if(Input.GetKeyDown(KeyCode.Q)){
			StreamWriter mysw = new StreamWriter("Assets/Resources/abc.txt");
			foreach(GameObject cp in checkpoint){
				mysw.WriteLine(cp.transform.position.x+","+cp.transform.position.y+","+cp.transform.position.z);
			}
			//writePositionTofloatString();
			//mysw.Flush();
			mysw.Close();
		//}
	}

	void writePositionTofloatString(){
		
	}

}
