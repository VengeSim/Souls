using System;
using System.IO;

namespace Venge
{
	public static class Save
	{
		
		public static void InitSaveDirectory(){
		
			if(!Save.DirectoryExists()){
			
				Save.CreateDirectory();
				
			}
		}
		
		public static string GetDirectory()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Vengeance/";
		}
		
		public static string GetDirectory(string dir)
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Vengeance/" + dir + "/";
		}
		
		public static bool DirectoryExists()
		{
			if(Directory.Exists(Save.GetDirectory()))
			{
				return true;
			}
			return false;
		}
		
		public static bool DirectoryExists(string dir)
		{
			if(Directory.Exists(Save.GetDirectory() + dir))
			{
				return true;
			}
			return false;
		}
		
		public static void CreateDirectory()
		{
			Directory.CreateDirectory(Save.GetDirectory());
		}
		
		public static void CreateDirectory(string dir)
		{
			Directory.CreateDirectory(Save.GetDirectory() + dir);
		}
		
		public static bool FileExists(string fileName)
		{
			return File.Exists(Save.GetDirectory() + fileName);
		}
		
		public static bool FileExists(string fileName, string dir)
		{
			return File.Exists(Save.GetDirectory(dir) + fileName);
		}
		
		public static FileStream CreateFileInDirectory(string fileName)
		{
			return File.Create(Save.GetDirectory() + fileName);
		}
		
		public static FileStream CreateFileInDirectory(string fileName, string dir)
		{
			return File.Create(Save.GetDirectory(dir) + fileName);
		}
		
		public static FileStream OpenFileInDirectory(string fileName)
		{
			return File.Open(Save.GetDirectory() + fileName, FileMode.Open);
		}
		
		public static FileStream OpenFileInDirectory(string fileName, string dir)
		{
			return File.OpenWrite(Save.GetDirectory(dir) + fileName);
		}
		
	}
}
