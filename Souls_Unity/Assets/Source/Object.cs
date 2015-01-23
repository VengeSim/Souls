using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Venge;


namespace Venge
{
	public class Object
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
		
		public Object()
		{
			this.name = "Ingame Object";
			this.description = "Base Class for all Game Objects";
		}
		
		public Object(string name, string description)
		{
			this.name = name;
			this.description = description;
		}
	}
}

