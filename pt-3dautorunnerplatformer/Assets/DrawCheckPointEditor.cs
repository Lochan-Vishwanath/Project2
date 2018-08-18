//	Name			Chau Tran
//	Last Modified	Apr 24th,2016

using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
//[ExecuteInEditMode]
[CustomEditor(typeof(DrawCheckPoint))]
public class DrawCheckPointEditor : Editor {
     public override void OnInspectorGUI()
     {
         DrawDefaultInspector();
         
         DrawCheckPoint myScript = (DrawCheckPoint)target;
         if(GUILayout.Button("Create objects"))
         {
            myScript.Function1();
         }
     }
	 
 }
