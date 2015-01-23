using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Venge;

namespace Venge
{
	public class Cell
	{
		protected GridIndex2D index;
		
		public GridIndex2D Index{get{return index;}}
		
		public Cell(GridIndex2D index)
		{
			this.index = index;
		}
	}
}

