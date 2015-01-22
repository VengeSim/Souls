using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Venge;

namespace Venge{

	public struct GridIndex3D
	{
		public int x;
		public int y;
		public int z;
		
		public GridIndex3D(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public Vector3 ToVector3()
		{
			return new Vector3(this.x, this.y, this.z);
		}
		public override string ToString ()
		{
			return string.Format ("[GridIndex]({0}, {1}, {2})",this.x, this.y, this.z);
		}
		public GridIndex3D West()
		{
			return new GridIndex3D(this.x - 1, this.y, this.z);
		}
		public GridIndex3D East()
		{
			return new GridIndex3D(this.x + 1, this.y, this.z);
		}
		public GridIndex3D South()
		{
			return new GridIndex3D(this.x, this.y, this.z - 1);
		}
		public GridIndex3D North()
		{
			return new GridIndex3D(this.x, this.y, this.z + 1);
		}
		public GridIndex3D Down()
		{
			return new GridIndex3D(this.x, this.y - 1, this.z);
		}
		public GridIndex3D Up()
		{
			return new GridIndex3D(this.x, this.y + 1, this.z);
		}
		public GridIndex3D[] AdjacentIndices(int radius)
		{
			//create neg Number array
			int[] negNumArray = new int[10];
			int startNum = 1;
			for(int _i = 0; _i < negNumArray.GetLength(0); _i++)
			{
				negNumArray[_i] = startNum;
				startNum += 2;
			}
			
			//make sure radius is in range of negNumArray
			if (radius <= 0){radius = 1;}
			if (radius > 10){radius = 1;}
			
			int _negRadius 	= radius * -1;
			
			int power = (int)Mathf.Pow((float)negNumArray[radius], 3f);
			GridIndex3D[] indices = new GridIndex3D[power];
			
			int _count 	= 0;
			for(int _x = _negRadius; _x <= radius; _x++)
			{
				for(int _y = _negRadius; _y <= radius; _y++)
				{
					for(int _z = _negRadius; _z <= radius; _z++)
					{
						indices[_count] = new GridIndex3D(_x + this.x, _y + this.y, _z + this.z);
						_count++;
					}
				}
			}
			return indices;
		}
	}
}
