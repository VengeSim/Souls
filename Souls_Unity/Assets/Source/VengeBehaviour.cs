using UnityEngine;
using System.Collections;

public class VengeBehaviour : MonoBehaviour 
{

	protected Global global;


	public Global Global{get{return global;}}
	
	void Awake()
	{
		global = transform.Find("Global").GetComponent<Global>();
	}
}
