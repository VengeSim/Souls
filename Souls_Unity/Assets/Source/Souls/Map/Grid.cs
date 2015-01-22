using System;
using System.IO;
using System.Reflection;
using UnityEngine;
using Venge;
using Souls;

namespace Souls
{
	public class Grid : SoulsObject
	{
		
		protected Cell[,] grid;
		
		
		public Cell[,] GetArray {get {return grid;}}
		public Cell this[int x, int z]
		{
			get{return this.grid[x, z];}
			set{this.grid[x, z] = value;}
		}
		public int SizeX{get{return this.grid.GetLength(0);}}
		public int SizeZ{get{return this.grid.GetLength(1);}}
		
		public Grid(int x, int z)
		{
			this.grid = new Cell[x, z];
		}
		
		
		#region Private Members
		
		private bool IsInRange(GridIndex2D index){
			int x = index.x;
			int z = index.z;
			
			if(x < 0){return false;}
			if(z < 0){return false;}
			
			if(x > this.SizeX - 1){return false;}
			if(z > this.SizeZ - 1){return false;}
			
			return true;
		}
		
		
		#endregion Private Members
		
		#region Get Directions N.NE.E.SE.S.SW.W.NW.
		
		public Cell GetN(Cell cell)
		{
			return this.GetN(cell, 1);
		}
		public Cell GetS(Cell cell)
		{
			return this.GetS(cell, 1);
		}		
		public Cell GetE(Cell cell)
		{
			return this.GetE(cell, 1);
		}
		public Cell GetW(Cell cell)
		{
			return this.GetW(cell, 1);
		}
		
		public Cell GetNE(Cell cell)
		{
			return this.GetE (this.GetN(cell, 1), 1);
		}
		public Cell GetSE(Cell cell)
		{
			return this.GetE (this.GetS(cell, 1), 1);
		}
		public Cell GetNW(Cell cell)
		{
			return this.GetW (this.GetN(cell, 1), 1);
		}
		public Cell GetSW(Cell cell)
		{
			return this.GetW (this.GetS(cell, 1), 1);
		}
		
		
		/* Distance
		3 3 3 3 3 3 3
		3 2 2 2 2 2 3
		3 2 1 1 1 2 3
		3 2 1 0 1 2 3
		3 2 1 1 1 2 3
		3 2 2 2 2 2 3
		3 3 3 3 3 3 3
		*/
		
		
		public Cell GetN(Cell cell, int distance)
		{
			if(!this.IsInRange(cell.Index)){return null;}
			return this.GetArray[cell.Index.x, cell.Index.z + distance];
		}
		public Cell GetS(Cell cell, int distance)
		{
			if(!this.IsInRange(cell.Index)){return null;}
			return this.GetArray[cell.Index.x, cell.Index.z - distance];
		}
		public Cell GetE(Cell cell, int distance)
		{
			if(!this.IsInRange(cell.Index)){return null;}
			return this.GetArray[cell.Index.x + distance, cell.Index.z];
		}
		public Cell GetW(Cell cell, int distance)
		{
			if(!this.IsInRange(cell.Index)){return null;}
			return this.GetArray[cell.Index.x - distance, cell.Index.z];
		}
		
		#endregion Get Directions N.NE.E.SE.S.SW.W.NW.
	}
}

