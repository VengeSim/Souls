using System;
using System.IO;
using System.Reflection;
using UnityEngine;
using Venge;
using Souls;

namespace Souls
{
	public class Cell : SoulsObject
	{
		protected GridIndex2D index;
		
		public GridIndex2D Index{get{return index;}}
		
		public Cell(GridIndex2D index)
		{
			this.index = index;
		}
	}
}

