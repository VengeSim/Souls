using UnityEngine;
using UnityEditor;
using System;
using System.Collections;




[CanEditMultipleObjects]
[CustomEditor(typeof(Save))]

public class Inspector_Save : Editor 
{
	public override void OnInspectorGUI()
	{
		Save script = (Save)target;
		//GameObject gObject = script.gameObject;
		
		DrawDefaultInspector();
		
			if(GUILayout.Button("Open Save Directory"))
			{
				EditorUtility.RevealInFinder(script.Directory);
			}
		
		//script.DebugMode = EditorGUILayout.Toggle("DebugMode", script.DebugMode);
		//EditorGUILayout.LabelField(String.Format ("Version : {0}", script.Version));
	}
}
