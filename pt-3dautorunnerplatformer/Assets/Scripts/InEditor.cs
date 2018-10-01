using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class InEditor : MonoBehaviour {

    public Transform a,b,c;
    float timee;

	    void Awake()
    {
        timee=Time.time;
        Debug.Log("Editor causes this Awake");
    }

    void Update()
    {
        if(Time.time>timee+5000){
            Instantiate(c.gameObject,this.transform.position,Quaternion.identity);
            timee=Time.time;
        }
        Debug.DrawLine(a.position,b.position);
    }
}
