using System;
using System.IO;
using System.Reflection;
using UnityEngine;
using Venge;
using Souls;

[assembly:AssemblyVersion("0.0.*")]

public class Initialization : MonoBehaviour {
	
	public string GameName = "Souls";
	public string SaveFileExt = "sl";
	public string CharacterSaveFileExt = "slChar";
	public string MapFileExt = "slMap";
	public bool DebugMode = true;
	public int VersionMajor = 0;
	public int VersionMinor = 0;
	public string Version;
	
	[HideInInspector]
	public int VersionBuild = 0;
	[HideInInspector]
	public int VersionRevision = 0;
	[HideInInspector]
	public string SaveLocation;
	public string MapsLocation;
		
	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	
		// Create Save Directory
		this.SaveLocation = String.Format("{0}/{0}_{1}_{2}", this.GameName, this.VersionMajor, this.VersionMinor);
		this.MapsLocation = String.Format("{0}/{0}_{1}_{2}/Maps", this.GameName, this.VersionMajor, this.VersionMinor);
		
		Save.InitSaveDirectory();
	}
	
	void Start () 
	{
		this.InitVersion();
		IntFileStructure ();
		
	}
	
	void InitVersion()
	{
		this.VersionBuild = Assembly.GetExecutingAssembly ().GetName ().Version.Build;
		this.VersionRevision = Assembly.GetExecutingAssembly ().GetName ().Version.Revision;
		this.Version =  String.Format("{0}.{1}.{2}.{3}", this.VersionMajor, this.VersionMinor, this.VersionBuild, this.VersionRevision);
	}

	void IntFileStructure ()
	{
		this.InitSaveDataFile ("Prefs", this.SaveFileExt);
		
		//Create Map Directory
		if(!Save.DirectoryExists(this.MapsLocation)){
			Save.CreateDirectory(this.MapsLocation);
		}
		
	}

	
	
	string AddFileExt(string fileName, string ext)
	{
		return String.Format("{0}.{1}", fileName, ext);
	}
	
	string GetSaveDirectory(){
		return this.SaveLocation;
	}
	
	void InitSaveDataFile(string fileName, string ext)
	{
		string file = this.AddFileExt(fileName, ext);
		
		if(!Save.DirectoryExists(this.SaveLocation)){
			Save.CreateDirectory(this.SaveLocation);
		}
		
		
		if(!Save.FileExists(file, this.SaveLocation)){
			FileStream fs = Save.CreateFileInDirectory(file, this.SaveLocation);
			
			using (StreamWriter sw = new StreamWriter(fs))
			{
				sw.WriteLine(this.GameName);
				sw.WriteLine(this.Version);
			}
		}
		
	}
	
	
}
