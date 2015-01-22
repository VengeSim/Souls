using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Venge;

namespace Venge{
	
	public struct GridIndex2D
	{
		public int x;
		public int z;
		
		public GridIndex2D(int x, int z)
		{
			this.x = x;
			this.z = z;
		}
		public Vector2 ToVector2()
		{
			return new Vector3(this.x,this.z);
		}
		public override string ToString ()
		{
			return string.Format ("[{0} , {1}]",this.x, this.z);
		}
		public GridIndex2D West()
		{
			return new GridIndex2D(this.x - 1, this.z);
		}
		public GridIndex2D East()
		{
			return new GridIndex2D(this.x + 1, this.z);
		}
		public GridIndex2D South()
		{
			return new GridIndex2D(this.x, this.z - 1);
		}
		public GridIndex2D North()
		{
			return new GridIndex2D(this.x, this.z + 1);
		}
//		public GridIndex2D[] AdjacentIndices(int radius)
//		{
//
//		}
	}
}
