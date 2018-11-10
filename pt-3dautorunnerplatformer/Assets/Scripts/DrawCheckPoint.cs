//	Name			Chau Tran
//	Last Modified	Apr 24th,2016

using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
//[ExecuteInEditMode]

public class DrawCheckPoint : MonoBehaviour{
 
	string line;
	[SerializeField]
	Vector3 StartingPosition;

    Vector3[] positions=new Vector3[200];

	Vector3 NextPosition;

    public LineRenderer linerender;
    bool linerenderstart=false;

   public void Function1(){
	   	StreamReader file =new StreamReader("Assets/Resources/abc.txt");
	    while((line=file.ReadLine())!=null){
			NextPosition=StringToVector3(line);
			Debug.DrawLine(StartingPosition,NextPosition,Color.white,10000f);
			StartingPosition=NextPosition;
		}
   }

   public void Functon2(){
       StreamReader file=new StreamReader("Assets/Resources/abc.txt");
       int i=0;
       while((line=file.ReadLine())!=null){
           positions[i++]=StringToVector3(line);
       }
       linerender.positionCount=positions.Length;
        linerenderstart=true;
   }
   public static Vector3 StringToVector3(string sVector)
    {
        
        // if (sVector.StartsWith ("(") && sVector.EndsWith (")")) {
        //     sVector = sVector.Substring(1, sVector.Length-2);
        // }
 
         // split the items
         string[] sArray = sVector.Split(',');
 
         // store as a Vector3
         Vector3 result = new Vector3(
             float.Parse(sArray[0]),
             float.Parse(sArray[1]),
             float.Parse(sArray[2]));
 
        return result;
    } 

    void Update(){
        if(linerenderstart){
        //foreach(Vector3 position in positions){
            //linerender.SetPositions(positions);
            for(int i=0;i<positions.Length;i++){
                linerender.SetPosition(i,positions[i]);
            }
            //linerenderstart=false;
        }
        //}
    }
 }
