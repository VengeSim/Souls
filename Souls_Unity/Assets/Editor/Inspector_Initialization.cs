using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using Venge;




[CanEditMultipleObjects]
[CustomEditor(typeof(Initialization))]

public class Inspector_Initialization : Editor 
{
	public override void OnInspectorGUI()
	{
		//Initialization script = (Initialization)target;
		//GameObject gObject = script.gameObject;
		
		DrawDefaultInspector();
		
			if(GUILayout.Button("Open Save Directory"))
			{
				EditorUtility.RevealInFinder(Save.GetDirectory());
			}
		
		//script.DebugMode = EditorGUILayout.Toggle("DebugMode", script.DebugMode);
		//EditorGUILayout.LabelField(String.Format ("Version : {0}", script.Version));
	}
}
