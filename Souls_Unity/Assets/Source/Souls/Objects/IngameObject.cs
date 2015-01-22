using System;
using System.IO;
using System.Reflection;
using UnityEngine;
using Venge;
using Souls;

namespace Souls
{
	public class IngameObject : SoulsObject
	{
		protected string name;
		protected string description;
		protected Cell cell;

		public string Name {
			get {
				return name;
			}
		}

		public string Description {
			get {
				return description;
			}
		}
		
		public IngameObject()
		{
			this.name = "Ingame Object";
			this.description = "Base Class for all Game Objects";
		}
		
		public IngameObject(string name, string description)
		{
			this.name = name;
			this.description = description;
		}
	}
}

