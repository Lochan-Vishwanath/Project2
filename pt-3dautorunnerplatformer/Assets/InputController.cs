using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	public static bool YesA,YesB;
	public static bool Long_yesA,Long_yesB;

	public void ActionA(){
		YesA=true;
		if(Input.GetTouch(0).phase==TouchPhase.Began||Input.GetTouch(1).phase==TouchPhase.Began){
			Long_yesA=true;
		}
	}
	public void ActionB(){
		YesB=true;
		if(Input.GetTouch(0).phase==TouchPhase.Began){
			Long_yesB=true;
		}
	}
	public void StopSctionA(){
		YesA=false;
	}
	public void StopSctionB(){
		YesB=false;
	}

	public void LongActionA(){
		if(Input.GetTouch(0).phase==TouchPhase.Began||Input.GetTouch(1).phase==TouchPhase.Began){
			Long_yesA=true;
		}
	}
	public void LongActionB(){
		if(Input.GetTouch(0).phase==TouchPhase.Began||Input.GetTouch(1).phase==TouchPhase.Began){
			Long_yesB=true;
		}
	}


	void Update(){
		Debug.Log(YesA+"   "+YesB);
		//Debug.Log(Input.GetTouch(0).phase);
		if(Long_yesA==true  && (Input.GetTouch(0).phase==TouchPhase.Ended))
			Long_yesA=false;
		if(Long_yesB==true  && (Input.GetTouch(0).phase==TouchPhase.Ended))
			Long_yesB=false;
	}
}
